using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;
        Car car;

        public CarManager(ICarDal ıCarDal)
        {
            _CarDal = ıCarDal;
        }
        
        
        public void Add(Car car)
        {
            if(car.Name.Length>2 && car.DailyPrice > 0)
            {
               _CarDal.Add(car);
            }
            else
            {
                Console.WriteLine("Please check your information.");
            }
        }
        public void Update(Car car)
        {
            _CarDal.Update(car);
        }
        public void Delete(Car car)
        {
            _CarDal.Delete(car);
        }
        

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {

            return _CarDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _CarDal.GetAll(p => p.ColorId == id);
        }
        public List<CarDetailDto> GetCarDetails()
        {
            return _CarDal.GetCarDetails();
        }

        public List<Car> GetById(int carId)
        {
            return _CarDal.GetAll(p => p.Id == carId);
        }
    }
}
