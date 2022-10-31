 using Microsoft.AspNetCore.Mvc;
using Northwind.Web.Models;
using Northwind.Web.Repository;

namespace Northwind.Web.Controllers
{
    public class EmployeeController : Controller
    {
        // use dependency injection
        private readonly IEmployee _IEmployee;


        public EmployeeController(IEmployee iEmployee)
        {
            _IEmployee = iEmployee;
        }

        public IActionResult ListEmployee()
        {
           /* var listOfEmployee = new List<Employee>
            {
                new Employee {Id=1001,Name="Kang Dian", BirthDate = new DateTime(2000,12,01)},
                new Employee {Id=1001,Name="Celine", BirthDate = new DateTime(2001,01,12)},
                new Employee {Id=1001,Name="Arya", BirthDate = new DateTime(2002,10,18)}
            };*/ 
             return View("ListEmployee", _IEmployee.GetAll());
        }

        public IActionResult Category()
        {
            return View();
        }
    }
}