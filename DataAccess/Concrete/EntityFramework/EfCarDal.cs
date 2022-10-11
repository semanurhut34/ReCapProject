using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from car in context.Car
                             join brand in context.Brand on car.BrandId equals brand.BrandId
                             join color in context.Color on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 BrandName = brand.BrandName,
                                 CarName = car.Name,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,

                             };
                return result.ToList();


            }
            {

            }
        }

    }
}
