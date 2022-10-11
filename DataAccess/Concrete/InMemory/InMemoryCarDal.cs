using DataAccess.Abstract;
using Entities.Concrete;
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
                new Car{ Id = 1, BrandId=1, ColorId=1,DailyPrice=1000, Description="Clio", ModelYear=2001},
                new Car{ Id = 2, BrandId=2, ColorId=2,DailyPrice=1500, Description="Ford", ModelYear=2020},
                new Car{ Id=3, BrandId=2, ColorId=2,DailyPrice=5000, Description ="Mercedes", ModelYear=2022},
                new Car{ Id=4, BrandId=3, ColorId=2,DailyPrice=3000, Description="Hyundai", ModelYear=2022},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletecar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deletecar);
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

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car uptatedCar= _cars.SingleOrDefault(c=> c.Id == car.Id);
            uptatedCar.BrandId=car.BrandId;
            uptatedCar.ColorId=car.ColorId;
            uptatedCar.DailyPrice=car.DailyPrice;
            uptatedCar.Description=car.Description;
        }
    }
}
