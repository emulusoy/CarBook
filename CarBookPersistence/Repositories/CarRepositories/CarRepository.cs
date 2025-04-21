﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using CarBookPersistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBookPersistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Car> GetCarListWithBrands()
        {
            var values=_context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }
    }
}
