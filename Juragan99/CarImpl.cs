using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juragan99
{
    internal class CarImpl : ICar
    {
        public List<Car> FindRevenueRange(List<Car> list, decimal startFrom, decimal endtO)
        {
            var revRange = new List<Car>();

            foreach (var item in list)
            {
                if(item.TotalRevenue > startFrom && item.TotalRevenue <= endtO)
                {
                    revRange.Add(item);
                }
            }

            return revRange;
            
        }

        public List<Car> GetCars()
        {

            SUV suv1 = new SUV("D 1001 UM", 2015, "SUV", 500_000, 100_000);
            SUV suv2 = new SUV("D 1002 UM", 2019, "SUV", 500_000, 100_000);

            Taxi taxi1 = new Taxi("D 88 UK", 2018, "Taxi", 5, 4_500, 40, 10_000);
            Taxi taxi2 = new Taxi("D 88 UK", 2018, "Taxi", 10, 4_500, 100, 10_000);

            Angkot angkot1 = new Angkot("D 55 UJ", 2016, "Angkot", 4_500, 35);
            Angkot angkot2 = new Angkot("D 55 UJ", 2015, "Angkot", 4_500, 40);

            return new List<Car> { suv1, suv2, taxi1, taxi2, angkot1, angkot2 };

        }

        public Dictionary<string, decimal> GetTotalRevenueByType(List<Car> list)
        {
            var totalRev = new Dictionary<string, decimal>();
            decimal revSUV = 0;
            decimal revTaxi = 0;
            decimal revAngkot = 0;
            foreach (var item in list)
            {
                if(item.Type == "SUV")
                {
                    revSUV += item.TotalRevenue;
                }
                else if (item.Type == "Taxi")
                {
                    revTaxi += item.TotalRevenue;
                }
                else if(item.Type == "Angkot")
                {
                    revAngkot += item.TotalRevenue;
                }
            }
            totalRev.Add("SUV", revSUV);
            totalRev.Add("Taxi", revTaxi);
            totalRev.Add("Angkot", revAngkot);

            return totalRev;
            
        }

        public void ShowListRevenue(Dictionary<string, decimal> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        public Dictionary<string, int> TotalCarByType(List<Car> list)
        {
            var totalType = new Dictionary<string, int>();
            int totalSUV = 0;
            int totalTaxi = 0;
            int totalAngkot = 0;
            foreach (var item in list)
            {
                if (item.Type == "SUV")
                {
                    totalSUV++;
                }
                else if (item.Type == "Taxi")
                {
                    totalTaxi++;
                }
                else if (item.Type == "Angkot")
                {
                    totalAngkot++;
                }
            }
            totalType.Add("SUV", totalSUV);
            totalType.Add("Taxi", totalTaxi);
            totalType.Add("Angkot", totalAngkot);
            return totalType;
        }

        public void ShowListType(Dictionary<string, int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item} ");
            }
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}
