﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        List<CarFeature> GetCarFeaturesByCarId(int carId); 
        void ChangeCarFeatureAvailableToFalse(int id);
        void ChangeCarFeatureAvailableToTrue(int id);
        void CreateCarFeatureByCar(CarFeature carFeature);
    }
}
