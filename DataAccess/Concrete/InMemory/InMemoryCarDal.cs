﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
               new Car{CarId=1,BrandId=1,ColorId=2,ModelYear= "1984",DailyPrice=10000,Description="hurda :)"},
               new Car{CarId=1,BrandId=1,ColorId=1,ModelYear="2000",DailyPrice=50000,Description="hareket ediyor :)"},
               new Car{CarId=1,BrandId=2,ColorId=2,ModelYear="2010",DailyPrice=700000,Description="ilk araba için ideal:)"},
               new Car{CarId=1,BrandId=2,ColorId=1,ModelYear="2011",DailyPrice=80000,Description="4 tekeri var :)"},
               new Car{CarId=1,BrandId=3,ColorId=3,ModelYear="2002",DailyPrice=60000,Description="doktordan temiz :)"},
               new Car{CarId=1,BrandId=3,ColorId=4,ModelYear="2007",DailyPrice=65000,Description="ayağımı yerden kesse yeter :)" },
            };         
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int CarId)
        {
            return _cars.FirstOrDefault(c => c.CarId == CarId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
