using Day4.OOP_Part2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.OOP_Part2
{
    internal interface IEmployee
    {
        public List<Employee> InitDataEmployee();

        public void ShowList<T>(ref List<T> list);

        public Employee FindEmployeeByID(List<Employee> list, int id);

        public decimal GetTotalSalary<T>(ref List<T> list);

        public List<Employee> FindSalaryRange(List<Employee> list, decimal startFrom, decimal endFrom);

        public Dictionary<string, int> GetTotalEmployeeById(List<Employee> list);
    }
}
