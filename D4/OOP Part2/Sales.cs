using System;
using System.Collections.Generic;
using System.Globalization;

namespace Day4.OOP_Part2

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
            this.Role = "Sales";
            TotalSalaryEmp = basicSalary + (basicSalary * (bonus/100)) + (basicSalary / (commision/100));
        }

        public decimal Bonus { get => bonus; set => bonus = value; }
        public decimal Commision { get => commision; set => commision = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Bonus = {this.bonus.ToString("C", new CultureInfo("id-ID"))} | Commision = {this.commision.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}