﻿using Business.Concrete;
using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);

                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.ModelName);
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}