using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {
        //List<Car> _car;

        //public InMemoryCarDal()
        //{
        //    _car = new List<Car>
        //    {
        //        new Car { ID=1,BrandID=1,ColorID=2,ModelYear=2012,DailyPrice=100,Description="Spor Araba"},
        //        new Car { ID = 2, BrandID = 3, ColorID = 1, ModelYear = 2016, DailyPrice = 200, Description = "Arazi Arabası" },
        //        new Car { ID = 3, BrandID = 2, ColorID = 1, ModelYear = 2008, DailyPrice = 45, Description = "Spor Araba" },
        //        new Car { ID = 4, BrandID = 1, ColorID = 2, ModelYear = 2010, DailyPrice = 120, Description = "Sedan Araba" }
        //    };

        //}
        //public void Add(Car car)
        //{
        //    _car.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _car.SingleOrDefault(c => c.ID == car.ID);

        //    _car.Remove(carToDelete);
        //}

        //public List<Car> GetAll()
        //{
        //    return _car;
        //}

        //public List<Car> GetById(int carId)
        //{
        //    return _car.Where(c => c.ID == carId).ToList();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUptade = _car.SingleOrDefault(c => c.ID == car.ID);
        //    carToUptade.ID = car.ID;
        //    carToUptade.BrandID = car.BrandID;
        //    carToUptade.ColorID = car.ColorID;
        //    carToUptade.DailyPrice = car.DailyPrice;
        //    carToUptade.ModelYear = car.ModelYear;
        //    carToUptade.Description = car.Description;



    }

}
