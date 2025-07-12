using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Domain.Entities;
using CarBookPersistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBookPersistence.Repositories.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;

        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<CarPricing> GetCarsWithPricingWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car)
                .ThenInclude(x => x.Brand).Include(x => x.Pricing)
                .ToList();
            return values;
        }
    }
}
