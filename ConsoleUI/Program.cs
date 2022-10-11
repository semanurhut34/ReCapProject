// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

using System;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ctrl+k+d -> format
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(4))
            {
                Console.WriteLine(car.DailyPrice);
            }
           
           


        }
    }
}

