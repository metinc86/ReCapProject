using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarManager carManager = new CarManager(new EfCarDal()); 
            /*
            Car car5 = new Car {Id= 5, BrandId = 3, ColorId = 3, DailyPrice = 380, Description = "Audi A4" };
            Car car6 = new Car {Id= 6, BrandId = 3, ColorId = 9, DailyPrice = 670, Description = "Audi S7" };
            
            carManager.(car5);
            carManager.Add(car6); 
            */
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Description);
            } 
            
        }
    }
}
