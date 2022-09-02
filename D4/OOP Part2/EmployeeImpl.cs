using D4.PartOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.OOP_Part2
{
    internal class EmployeeImpl : IEmployee
    {
        public List<Employee> FindSalaryRange(List<Employee> list, decimal startFrom, decimal endFrom)
        {
            var empRange = new List<Employee>();

            foreach (var item in list)
            {
                if(item.TotalSalaryEmp > startFrom && item.TotalSalaryEmp <= endFrom)
                {
                    empRange.Add(item);
                }
            }

            return empRange;
        }

        public Dictionary<string, int> GetTotalEmployeeById(List<Employee> list)
        {
            var roleKerja = new Dictionary<string, int>();
            /*foreach (var item in list)
            {
                if(item.Role == "Programmer")
                {
                    roleKerja = item;
                }
            }*/


            return roleKerja;
        }

        public decimal GetTotalSalary<T>(ref List<T> list)
        {
            var total = 0M;
            foreach (var item in list.OfType<Employee>())
            {
                total += item.TotalSalaryEmp;
            }
            return total;
        }

        public List<Day4.OOP_Part2.Employee> InitDataEmployee()
        {
            //throw new NotImplementedException();
            Employee emp1 = new Employee(); // DIA AKAN MEMANGGIL DEFAULT CONSTRUCTOR
            emp1.EmpId = 1000;
            emp1.FirstName = "Arif";
            emp1.LastName = "Fajar  ";
            emp1.City = "Bogor";
            emp1.JoinDate = DateTime.Now;
            emp1.BasicSalary = 10_000_000;
            emp1.Role = "Programmer";

            Employee emp2 = new Employee(1001, "Code", "Academy", new DateTime(), 8_000_000); // MEMANGGIL YG PARAMETER
            emp2.Role = "Programmer";
            Employee emp3 = new Employee(1002, "Rini", "Marlina", new DateTime(2022, 8, 29), 8_500_000, "Cicaheum"); // Call construcor si overloading
            emp3.Role = "Programmer";
            Employee emp4 = new Employee(1003, "Ivan", "Gunawan", new DateTime(2022, 8, 12), 7_000_000, "Jakaerta", "Programmer");
            Programmer prog1 = new Programmer(1004, "Udin", "Sedunia", new DateTime(2022, 8, 17), 10_000_000, "Bogor", 500_000);
            Sales sales1 = new Sales(1005, "Widi", "Kosasih", new DateTime(2022, 8, 17), 5_000_000, "Palembang", 15, 20);
            QA QA1 = new QA(1006, "Yuli", "Ayu", new DateTime(2022, 8, 26), 5_500_000, "Medan", 1_000_000);
            //List<Employee> listEmployees = new List<Employee> { emp1, emp2, emp3, emp4, prog1, sales1, QA1 };

            return new List<Employee> { emp1, emp2, emp3, emp4, prog1, sales1, QA1 };
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item} ");
            }
        }

        Employee IEmployee.FindEmployeeByID(List<Employee> list, int id)
        {
            //throw new NotImplementedException();

            Employee? emps = null;
            foreach (var item in list)
            {
                if(item.EmpId == id)
                {
                    emps = item;
                }
            }
            return emps;
        }
    }
}
