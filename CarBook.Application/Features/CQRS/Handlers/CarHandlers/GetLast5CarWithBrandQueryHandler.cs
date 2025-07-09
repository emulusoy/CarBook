using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarWithBrandQueryHandler
    {

        private readonly ICarRepository _repository;

        public GetLast5CarWithBrandQueryHandler(ICarRepository carRepository)
        {
            _repository = carRepository;
        }

        public  List<GetLast5CarListWithBrandsQueryResult> Handle()
        {
            var values =  _repository.GetLast5CarListWithBrands();
            return values.Select(x => new GetLast5CarListWithBrandsQueryResult
            {
                BrandName=x.Brand.Name,
                BrandID = x.BrandID,
                BigImageUrl = x.BigImageUrl,
                CarID = x.CarID,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission
            }).ToList();
        }
    }
}
