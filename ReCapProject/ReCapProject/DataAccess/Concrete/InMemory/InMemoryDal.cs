using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryDal:ICarDal
    {
        List<Car> _car;

        public InMemoryDal()
        {
            _car = new List<Car>
            {
                new Car{BrandId=1,ColorId=1,DailyPrice=352,Description="Stonic", Year=2020},
                new Car{BrandId=1,ColorId=3,DailyPrice=250,Description="Picanto", Year=2020},
                new Car{BrandId=2,ColorId=1,DailyPrice=275,Description="Clio", Year=2020},
                new Car{BrandId=2,ColorId=1,DailyPrice=315,Description="Talisman", Year=2020},
                new Car{BrandId=3,ColorId=1,DailyPrice=372,Description="Corolla", Year=2021},

            };

        }


        void ICarDal.Add(Car car)
        {
            _car.Add(car);
        }

        void ICarDal.Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        void ICarDal.Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.Year = car.Year;
        }
        List<Car> ICarDal.GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(p => p.CarId == carId).ToList();
        }
    }
}
