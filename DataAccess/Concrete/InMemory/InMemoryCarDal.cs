using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=600,Description="Volkswagen Passat"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2008,DailyPrice=500,Description="Volkswagen Jetta"},
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear=2002,DailyPrice=400,Description="Dacia Duster"},
                new Car{Id=4,BrandId=3,ColorId=2,ModelYear=2005,DailyPrice=700,Description="Audi A4"},
                new Car{Id=5,BrandId=4,ColorId=1,ModelYear=2018,DailyPrice=650,Description="Toyota Corolla"},
                new Car{Id=6,BrandId=1,ColorId=4,ModelYear=2015,DailyPrice=450,Description="Volkswagen Polo"},
                new Car{Id=7,BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=400,Description="Dacia Logan"},
                new Car{Id=8,BrandId=2,ColorId=2,ModelYear=2013,DailyPrice=425,Description="Dacia Stepway"},
                new Car{Id=9,BrandId=3,ColorId=4,ModelYear=2015,DailyPrice=1000,Description="Audi R8"},
                new Car{Id=10,BrandId=3,ColorId=3,ModelYear=2017,DailyPrice=900,Description="Audi Sedan"},
                new Car{Id=11,BrandId=4,ColorId=3,ModelYear=2014,DailyPrice=1000,Description="Toyota Supra"},
                new Car{Id=12,BrandId=4,ColorId=2,ModelYear=2019,DailyPrice=900,Description="Toyota Hilux"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //silinecek elemanın referansını alarak silme işlemi gerçekleştiriyoruz
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
