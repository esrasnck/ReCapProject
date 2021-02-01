using Business.Abstract;
using Business.Concrete;
using System;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (Car item in carManager.GetAll())
            {
                Console.WriteLine($"Araba Açıklaması : {item.Description} - Fiyatı : {item.DailyPrice} - Yılı : {item.ModelYear}");
            }
        }
    }
}
