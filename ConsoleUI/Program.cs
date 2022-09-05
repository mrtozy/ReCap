
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandTest();

            CarDetailsTest();
        }

      

        private static void BrandTest()
        {
            BrandManager bm = new BrandManager(new EfBrandDal());

            bm.Update(new Brand { BrandId = 10, BrandName = "Herhangi birşey"});

            var result = bm.GetAll();

            foreach (var rental in result)
            {
                Console.WriteLine("{0} - {1}  ", rental.BrandId, rental.BrandName);
            }
        }
        
        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            foreach (var carDetail in result)
            {
              
                    Console.WriteLine("{0} - {1} - {2}", carDetail.CarId, carDetail.BrandName.Trim(), carDetail.ColorName.Trim());
                   
               
                

            }
        }
    }
    }

