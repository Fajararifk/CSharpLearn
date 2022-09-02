using System.Globalization;

namespace D4.PartOne
{
    internal class Employee
    {
        // instance variable
        private int empId;
        private string firstName;
        private string lastName;
        private DateTime joinDate;
        private Decimal basicSalary;
        private string city;
        private string role;
        private decimal totalSalaryEmp;
        // static variable
        // tugasnya global varibale yg scope nya yg ada di kelas dan bisa dipakai oleh emp1,emp2, emp3 nanti dia ngecounter
        public static int totalEmployee = 0;
        public static Decimal totalSalary = 0M;

        // default constructor atau empty constructor
        public Employee()
        {
            totalEmployee++;
            totalSalary += this.basicSalary;
            this.TotalSalaryEmp = this.basicSalary;
        }
        // kegunaan constructor adalah untuk inisial value dari attribute / object
        // constructor parameter
        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary)
        {
            this.empId = empId; //  new Random().Next(1000,1100);
            this.firstName = firstName;
            this.lastName = lastName;   
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            totalEmployee++;
            totalSalary += this.basicSalary;
            this.TotalSalaryEmp = this.basicSalary;
        }

        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, string role) : this(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.role = role;
        }

        // overloading constructor => PARAMETERNYA BISA DIKURANGIN ATAU BISA DITAMBAH
        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city) : this(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.city = city;
        }
        // tambah role




        // method return
        public override string? ToString()
        {
            return $"Employee = {this.empId} | {this.firstName} | {this.lastName} | {this.role} | Basic Salary : {this.BasicSalary} | Total Salary : {this.totalSalaryEmp.ToString("C", new CultureInfo("id-ID"))}";
        }

        public decimal GetTotalSalary()
        {
            return this.basicSalary;
        }



        // CREATE GET SET
        // get ambil value dari variable
        // set manipulasi instance variable(yg diatas itu tuh)
        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public decimal BasicSalary { get => basicSalary; set { basicSalary = value; totalSalaryEmp = basicSalary; } }
        public string City { get => city; set => city = value; }
        public string Role { get => role; set => role = value; }
        public decimal TotalSalaryEmp { get => totalSalaryEmp; set => totalSalaryEmp = value; }
    }
}