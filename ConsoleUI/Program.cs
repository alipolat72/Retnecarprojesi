using Business.Concrete;
using Business.Contants;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManeger carManeger = new CarManeger(new EfCarDal());
            // GetAllCar(carManeger);

            var result = carManeger.GetAll();

            if(result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Model + "/" + car.ModelYear);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message); 
            }

           
            
            //Console.WriteLine("araçlar Listelendi");

            Console.ReadLine();


          
            //AddCar(carManeger);

            //carManeger.AddCar (new Car { Id=15,Model="hyundai-i30",ModelYear="2024"
                                        // ,BrandId=1,ColorId=1,DailyPrice=1500,Description="açıklama"});

            
            Console.ReadLine();






            //GetCarsById(carManeger);

            //GetCarsByColor(carManeger);

            //GetByUnitPrice(carManeger);

           




            //BrandManeger brandManeger = new BrandManeger(new EfBrandDal());

            //GetAllBrandManeger(brandManeger);





            //ColorManeger colorManeger = new ColorManeger(new EfColorDal());

            //GetAllColor(colorManeger);

        }

        private static void GetAllColor(ColorManeger colorManeger)
        {
            foreach (var color in colorManeger.GetAll())
            {
                Console.WriteLine(color.ColorId + "/" + color.ColorName);
            }
        }

        private static void GetAllBrandManeger(BrandManeger brandManeger)
        {
            foreach (var brend in brandManeger.GetAll())
            {
                Console.WriteLine(brend.BrandId + " marka.:" + brend.BrandName);
            }
        }

        private static void AddCar(CarManeger carManeger)
        {
            carManeger.AddCar(new Car
            {
                Id=15,
                BrandId = 1,
                ColorId = 2,
                Model = "hyundai-i30",
                ModelYear = "2023",
                DailyPrice = 2500,
                Description = "15-06-2024 eklenen-3"
            });
        }

        //private static void GetByUnitPrice(CarManeger carManeger)
        //{
        //    foreach (var car in carManeger.GetByUnitPrice(1250, 2000).Data)
        //    {
        //        Console.WriteLine(car.Id + " / " + car.BrandId + " / " + car.Model + " / " + car.ModelYear + " / " + car.DailyPrice);
        //    }
        //}

        //private static void GetCarsByColor(CarManeger carManeger)
        //{
        //    foreach (var c in carManeger.GetCarsByColorId(1).Data)
        //    {
        //        Console.WriteLine(c.ColorId + " " + c.Model);
        //    }
        //}

        //private static void GetCarsById(CarManeger carManeger)
        //{
        //    foreach (var c in carManeger.GetCarsByBrandId(1).Data)
        //    {
        //        Console.WriteLine(c.BrandId + " " + c.Model);
        //    }
        //}

        //private static void GetAllCar(CarManeger carManeger)
        //{
        //    var result = carManeger.GetAll();
        //    if (result.Success == true)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //        Console.WriteLine(car.Id + "brandId..:" + car.BrandId + " ColorId" + car.ColorId 
        //            + " Model" + car.Model + " Yıl" + car.ModelYear + " / " + car.DailyPrice);
        //        }
        //        Console.WriteLine(result.Message);
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }

           
        //}




    }
}
