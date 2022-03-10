using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal()); 
            Car car1 = new Car {BrandId=1, ColorId =3, DailyPrice=350, Description= "Rolls Royce" };
            Car car2 = new Car { BrandId = 5, ColorId = 7, DailyPrice = 750, Description = "Bugatti" };
            carManager.Add(car1);
            carManager.Add(car2);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
