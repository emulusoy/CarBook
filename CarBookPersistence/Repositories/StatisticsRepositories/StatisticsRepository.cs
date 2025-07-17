using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using CarBookPersistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBookPersistence.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly CarBookContext _context;

        public StatisticsRepository(CarBookContext context)
        {
            _context = context;
        }

        public int GetAuthorCount()
        {var value= _context.Authors.Count();
            return value; 
        }

        public decimal GetAvgRentPriceForDaily()
        {
            var value = _context.CarPricings
            .Where(x => x.PricingID == 2)
             .Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForMonthly()
        {
            var value = _context.CarPricings
             .Where(x => x.PricingID == 4)
              .Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            var value = _context.CarPricings
            .Where(x => x.PricingID == 3)
             .Average(x => x.Amount);
            return value;
        }

        public int GetBlogCount()
        {
           var value= _context.Blogs.Count();
            return value;   
        }

        public string GetBlogTitleByMaxBlogComment()
        {
            
            var values = 10;
            return values.ToString();
        }

        public int GetBrandCount()
        {
            return _context.Brands.Count();
        }

        public string GetBrandNameByMaxCar()
        {
            //maksimim arac sayisina sahip markayi dondurur


            var values = _context.Cars.GroupBy(x => x.BrandID).
                             Select(y => new
                             {
                                 BrandID = y.Key,
                                 Count = y.Count()
                             }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();
            string brandName = _context.Brands.Where(x => x.BrandID == values.BrandID).Select(y => y.Name).FirstOrDefault();
            return brandName;
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        {
            //gunluk max fiyatli araci getir
            int pricingID = _context.Pricings.Where(x => x.Name == "Day").Select(y => y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(y => y.PricingID == pricingID).Max(x => x.Amount);
            int carId = _context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carId).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            int pricingID = _context.Pricings.Where(x => x.Name == "Day").Select(y => y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(y => y.PricingID == pricingID).Min(x => x.Amount);
            int carId = _context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carId).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;
        }

        public int GetCarCount()
        {
            var value= _context.Cars.Count();
            return value;
        }

        public int GetCarCountByFuelElectric()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Electric").Count();
            return value;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            //dizel ve benzinli arac sayisi
            var value= _context.Cars.Where(x=>x.Fuel=="Gasoline" || x.Fuel=="Diesel").Count();
            return value;
        }

        public int GetCarCountByKmSmallerThen1000()
        {
            //1000 kmden dusuk araclar\

            var value = _context.Cars.Where(x => x.Km <= 1000).Count();
            return value;
        }

        public int GetCarCountByTranmissionIsAuto()
        {
            //otomatik vitesli arac sayisi
            var value= _context.Cars.Where(x => x.Transmission == "Automatic" || x.Transmission == "Otomatik").Count();
            return value;
        }

        public int GetLocationCount()
        {
           var value = _context.Locations.Count();
            return value;   
        }
    }
}
