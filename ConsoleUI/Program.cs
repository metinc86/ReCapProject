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
            
            Car car7 = new Car {Id= 7, BrandId = 6, ColorId = 3, DailyPrice = 380, Description = "BMW" };
            Car car8 = new Car {Id= 8, BrandId = 4, ColorId = 9, DailyPrice = 0, Description = "Audi S7" };
            
            carManager.Add(car7);
            carManager.Add(car8); 
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            } 
            
        }
    }
}
