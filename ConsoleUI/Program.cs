using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //Console.WriteLine("CarID" + "    " + "BrandId" + "    " + "ColorId" + "     " + "Model Year" + "      " + "Daily Price" + "      " + "Description");
            Console.WriteLine("-------------------------------------------------------------------------------");

            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + car.ModelName + car.ColorName + car.DailyPrice);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }


            //Console.WriteLine(car.Id + "         " + car.BrandId + "           " + car.ColorId + "           " + car.ModelYear + "             " + car.DailyPrice + "            " + car.Description);


            Console.WriteLine("-------------------------------------------------------------------------------");


        }
    }

    
}
