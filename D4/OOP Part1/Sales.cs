using System;
using System.Collections.Generic;
using System.Globalization;

namespace D4.PartOne
{
    internal class Sales : Employee
    {
        private decimal bonus;
        private decimal commision;

        public Sales(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal bonus, decimal commision) 
            : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Bonus = bonus;
            this.Commision = commision;
            TotalSalaryEmp = basicSalary + bonus + commision;
        }

        public decimal Bonus { get => bonus; set => bonus = value; }
        public decimal Commision { get => commision; set => commision = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Bonus = {this.bonus.ToString("C", new CultureInfo("id-ID"))} | Commision = {this.commision.ToString("C", new CultureInfo("id-ID"))}| {this.BasicSalary + this.bonus + this.commision} || Total Salary =  {this.TotalSalaryEmp.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}