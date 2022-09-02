// CREATE OBJECT CAR WITH PARAMETER
using System;
using System.Collections.Generic;
using static System.Console;
using Juragan99;

/*Car car1 = new Car("D 55 UJ", 2016, "Angkot");
Car car2 = new Car("D 55 UJ", 2015, "Angkot")*/
/*
SUV suv1 = new SUV("D 1001 UM", 2015, "SUV", 500_000, 100_000);
SUV suv2 = new SUV("D 1002 UM", 2019, "SUV", 500_000, 100_000);

Taxi taxi1 = new Taxi("D 88 UK", 2018, "Taxi", 5, 4_500, 40, 10_000);
Taxi taxi2 = new Taxi("D 88 UK", 2018, "Taxi", 10, 4_500, 100, 10_000);

Angkot angkot1 = new Angkot("D 55 UJ", 2016, "Angkot", 4_500, 35);
Angkot angkot2 = new Angkot("D 55 UJ", 2015, "Angkot", 4_500, 40);

List<Car> listCar = new List<Car> { suv1, suv2, taxi1, taxi2, angkot1, angkot2 };

foreach (var item in listCar)
{
    WriteLine(item.ToString());
}*/


WriteLine("\n======================================Implementation Interface========================================\n");

ICar cars = new CarImpl();
var listCar = cars.GetCars();
cars.ShowList(ref listCar);

WriteLine("\n==================================Total Revenue By Type=============================================\n");

var byRevenue = cars.GetTotalRevenueByType(listCar);
cars.ShowListRevenue(byRevenue);

WriteLine("\n==================================Total Car By Type=============================================\n");

var byType = cars.TotalCarByType(listCar);
cars.ShowListType(byType);

WriteLine("\n==================================Find Revenue Range=============================================\n");
var byRange = cars.FindRevenueRange(listCar,500_000,600_000);
cars.ShowList(ref byRange);
