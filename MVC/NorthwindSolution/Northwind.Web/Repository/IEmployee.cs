using Northwind.Web.Models;

namespace Northwind.Web.Repository
{
    public interface IEmployee
    {
        public List<Employee> GetAll();
    }
}
