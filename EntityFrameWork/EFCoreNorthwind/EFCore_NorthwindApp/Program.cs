using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EFCore_NorthwindDB;
using System;
using System.IO;

namespace EFCore_NorthwindDB
{
    class Program
    {
        private static IConfigurationRoot Configuration;
        // Untuk config instance ke sqlserver
        private static DbContextOptionsBuilder<NorthwindContext> optionsBuilder;
        static void Main(string[] args)
        {
            BuildConfiguration();
            Console.WriteLine($"ConnectionString : {Configuration.GetConnectionString("NorthwindDS")}");
            BuildOption();
            ListCustomer();
        }

        static void BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }

        static void BuildOption()
        {
            optionsBuilder = new DbContextOptionsBuilder<NorthwindContext>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("NorthwindDS"));
        }

        static void ListCustomer()
        {
            using (var db = new NorthwindContext(optionsBuilder.Options))
            {
                var customers = db.Customers.OrderByDescending(x => x.CompanyName).Take(10).ToList();
                foreach (var cust in customers)
                {
                    Console.WriteLine($"{cust.CompanyName} {cust.ContactName}");
                }
            }
        }
    }
}