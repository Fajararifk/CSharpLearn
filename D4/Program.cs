// OOP adalah metode desain software yg memodelkan karakteristik object di dunia nyata yg menggunakan pendekatan berupa class object juga inerasi antar objek

// state : menyimpan informasi untuk object sendiri
// behavior : apa yg bisa dilakukan object

// OBJECT ANALOGIKAN DENGAN TABLE

// OOP :
// 1. Encapsulation => mEMBUNGKUS ATRIBUT OBJECT SUPAYA VALUE NYA BISA DIRUBAH BY METHOD GA BOLEH LANGSUNG
    // -KEUNTUNGANNY PERUBAHAN DATA BISA DIVALIDASI, SEHINGGA DATA MENJAID VALID
    // -MENJAGA KONSISTEMSI ATTRIBUTE OBJECT KARENA PERUBAHAN HANYA MELALUI METHOD,
    // - MELINDUNGI DATA DARI UNAUTHORIZED ACCES
// 2. Inheritance =>
// 3. Polymorpsym
// 4. Abstraction
// 5. Interface

// class adalah blueprint atau cetakannya
// object adalah hasil cetakannya/instant dari kelas

using System;
using System.Collections.Generic;
using static System.Console;
// call class mployee
using D4.PartOne;
using Day4.OOP_Part2;
using System.Security.Cryptography;
using Day4.OOP_Part2;
using System.Globalization;
// gunakan encapsulation untuk manipulasi attribute object
/*emp1.firstName = "CodeID";`
emp1.empId = 1001;*/

// SETIAP CREATE OBJECT INSTANCE, GUNAKAN OPERATOR NEW
/*Employee emp1 = new Employee(); // DIA AKAN MEMANGGIL DEFAULT CONSTRUCTOR
emp1.EmpId = 1000;
emp1.FirstName = "Arif";
emp1.LastName = "Fajar  ";
emp1.City = "Bogor";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 10_000_000;
emp1.Role = "Programmer";

//Console.WriteLine(emp1.FirstName);
// CREATE OBJECT EMPLOYEE WITH PARAMATER CONSTRUCTOR
Employee emp2 = new Employee(1001, "Code", "Academy", new DateTime(), 10_000_000); // MEMANGGIL YG PARAMETER
emp2.Role = "Programmer";
Employee emp3 = new Employee(1002, "Rini", "Marlina", new DateTime(2022, 8, 29), 10_000_000, "Cicaheum"); // Call construcor si overloading
emp3.Role = "Programmer";
Employee emp4 = new Employee(1003, "Ivan", "Gunawan", new DateTime(2022, 8, 12), 10_000_000, "Jakaerta", "Programmer");



Console.WriteLine("          empdID firstName lastName basicSalary\n");
WriteLine(emp1.ToString());
WriteLine(emp2.ToString());
WriteLine(emp3.ToString());
WriteLine(emp4.ToString());

WriteLine($"Total Employee : {Employee.totalEmployee}");
WriteLine($"Total Total Salary : {Employee.totalSalary}");


// CREATE OBJECT PROGRAMMER
Programmer prog1 = new Programmer(1004, "Udin", "Sedunia", new DateTime(2022, 8, 17), 10_000_000, "Bogor", 500_000);

Console.WriteLine("====================================================================");

// CREATE OBJECT SALES 
Sales sales1 = new Sales(1005, "Widi", "Kosasih", new DateTime(2022, 8, 17), 5_000_000, "Palembang", 300_000, 200_000);

// CREATE OBJECT QA
QA QA1 = new QA(1006, "Yuli", "Ayu", new DateTime(2022, 8, 26), 5_500_000, "Medan", 1_000_000);

// CREATE STORE TO LIST
List<Employee> listEmployees = new List<Employee> { emp1, emp2, emp3, emp4, prog1 , sales1, QA1};
foreach (var item in listEmployees)
{
    WriteLine(item.ToString());
}
*/

/*Employee emp1 = new Employee(); // DIA AKAN MEMANGGIL DEFAULT CONSTRUCTOR
emp1.EmpId = 1000;
emp1.FirstName = "Arif";
emp1.LastName = "Fajar  ";
emp1.City = "Bogor";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 10_000_000;
emp1.Role = "Programmer";

//Console.WriteLine(emp1.FirstName);
// CREATE OBJECT EMPLOYEE WITH PARAMATER CONSTRUCTOR
Employee emp2 = new Employee(1001, "Code", "Academy", new DateTime(), 10_000_000); // MEMANGGIL YG PARAMETER
emp2.Role = "Programmer";
Employee emp3 = new Employee(1002, "Rini", "Marlina", new DateTime(2022, 8, 29), 10_000_000, "Cicaheum"); // Call construcor si overloading
emp3.Role = "Programmer";
Employee emp4 = new Employee(1003, "Ivan", "Gunawan", new DateTime(2022, 8, 12), 10_000_000, "Jakaerta", "Programmer");



Console.WriteLine("          empdID firstName lastName basicSalary\n");
WriteLine(emp1.ToString());
WriteLine(emp2.ToString());
WriteLine(emp3.ToString());
WriteLine(emp4.ToString());

WriteLine($"Total Employee : {Employee.totalEmployee}");
WriteLine($"Total Total Salary : {Employee.totalSalary}");


// CREATE OBJECT PROGRAMMER
Programmer prog1 = new Programmer(1004, "Udin", "Sedunia", new DateTime(2022, 8, 17), 10_000_000, "Bogor", 500_000);

Console.WriteLine("====================================================================");

// CREATE OBJECT SALES 
Sales sales1 = new Sales(1005, "Widi", "Kosasih", new DateTime(2022, 8, 17), 5_000_000, "Palembang", 300_000, 200_000);

// CREATE OBJECT QA
QA QA1 = new QA(1006, "Yuli", "Ayu", new DateTime(2022, 8, 26), 5_500_000, "Medan", 1_000_000);

// CREATE STORE TO LIST
List<Employee> listEmployees = new List<Employee> { emp1, emp2, emp3, emp4, prog1, sales1, QA1 };
foreach (var item in listEmployees)
{
    WriteLine(item.ToString());
}*/


WriteLine("\n======================================Implementation Interface========================================\n");

IEmployee empInf = new EmployeeImpl();

var listOfEmps = empInf.InitDataEmployee();
empInf.ShowList(ref listOfEmps);

WriteLine("\n======================================Found=============================================\n");
var emp = empInf.FindEmployeeByID(listOfEmps, 1002);
Write($"Found : {emp}\n");

WriteLine("\n==================================Total Salary All Employee=============================================\n");


var total = empInf.GetTotalSalary(ref listOfEmps);
WriteLine($"\nTotal Salary : {total.ToString("C", new CultureInfo("id-ID"))}");


WriteLine("\n=======================================Salary Range=========================================================\n");
var salaryRange = empInf.FindSalaryRange(listOfEmps, 4_500_00, 7_500_000);
empInf.ShowList(ref salaryRange);
ReadLine();