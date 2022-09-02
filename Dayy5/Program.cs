// abstract adalah blue print atau template untuk superclass(parent class), parent class akan mewarisi attribute dan method dari abstract class.
// ABSTRACT == INTERFACE, dimana akan di implementasikan di subclass.
// abstack punya attibute
// interface hanya kumpulan method

// CONTOH
// COBA BIKIN OBJEK MAKHLUK YG TAPI SETIAP MAKHLUK MEMIILIKI NAMA,

// HARUS ADA SUPER PARENT CLASS NYA

//CONTOH
// VEHICLE  ==> ABSTRACT CLASS
// ADA BAHAN BAKAR DAN CHICLETYPE DI VEHICLE
// CAR AND PLANE ==> PARENT CLASS DARI TAXI DAN CESSNA
//

using static System.Console;
using Day5;
using System.Globalization;

Person yuli = new Customer("Yuli", "Ayu", "yuli@gmail.com", new DateTime(1998, 4, 24), "131-001");
Customer widi = new Customer("Widi", "Amalia", "widi@gmail.com", new DateTime(1999, 8, 4), "131-003");
Customer rini = new Customer("Rini", "Marlina", "rini@gmail.com", new DateTime(1999, 9, 30), "131-002"); // BISA ANTARA KEDUANYA
Owner faiz = new Owner("Faiz", "Azhar", "faiz@gmail.com", new DateTime(1998, 8, 17), 3);
Owner anto = new Owner("Harfi", "Anto", "anto@gmail.com", new DateTime(1996, 8, 17), 2);

var listOfCustomer = new List<Person> { yuli, widi, rini, faiz, anto};

var incomeFaiz = new Dictionary<string, decimal>
{
    {"Toko Besi", 200_000_000 },
    {"Programming", 100_000_000 },
    {"Politisi", 30_000_000 }
};
faiz.TotalRevenue = faiz.TotalIncome(incomeFaiz);
var incomeAnto = new Dictionary<string, decimal>
{
    {"Judi Online", 100_000_000 },
    {"Programming", 200_000_000 }
};
anto.TotalRevenue = anto.TotalIncome(incomeAnto);   
var incomeYuli = new Dictionary<string, decimal> {
    {"Kontrakan", 10_000_000 },
    {"Toko", 100_000_000 }
};
yuli.TotalRevenue = yuli.TotalIncome(incomeYuli);

var incomeWidi = new Dictionary<string, decimal>
{
    {"Kosan", 20_000_000 },
    {"Jual Online", 6_000_000 }
};
widi.TotalRevenue = widi.TotalIncome(incomeWidi);

var incomeRini = new Dictionary<string, decimal>
{
    {"Supermarket", 50_000_000 },
    {"Rental Mobil", 40_000_000 }
};
rini.TotalRevenue = rini.TotalIncome(incomeRini);

foreach (var item in listOfCustomer)
{
    WriteLine(item);
};

Console.WriteLine("\n--------------------------------------------Revenue Highest-----------------------------------------------\n");
var listHighest = listOfCustomer.Where(x => x.TotalRevenue >= 50_000_000).ToList();
foreach (var item in listHighest)
{
    WriteLine(item.ToString());
}

Console.WriteLine("\n--------------------------------------------Revenue Min-----------------------------------------------\n");
var listMin = listOfCustomer.Min(x => x.TotalRevenue);
WriteLine($"Cust Min Revenue : {listMin.ToString("C", new CultureInfo("id-ID"))}");

Console.WriteLine("\n-------------------------------------------------Revenue Max----------------------------------------------------------\n");
var listMax = listOfCustomer.Max(x => x.TotalRevenue);
WriteLine($"Cust Min Revenue : {listMax.ToString("C", new CultureInfo("id-ID"))}");



var listLessThankMax = listOfCustomer.Where(x => x.TotalRevenue < listMax);
WriteLine("\n================================================Revenue Lower Than Max================================================\n");
foreach (var item in listLessThankMax)
{
    WriteLine(item.ToString());
}


WriteLine("\n=============================================== Select =================================================================\n");
var query = listOfCustomer.Select(cust => new
{
    FullName = cust.FirstName + " " + cust.LastName,
    Email = cust.Email,
    TotalRevenue = cust.TotalRevenue
});

foreach (var item in query)
{
    WriteLine(item);
};
Console.WriteLine("-------------------------Linq----------------------------");
LinQ.IntroLinq();