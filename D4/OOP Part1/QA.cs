using System;
using System.Collections.Generic;
using System.Globalization;

namespace D4.PartOne
{
    internal class QA : Employee
    {
        private decimal makan;

        public QA(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal makan) : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Makan = makan;
            TotalSalaryEmp = basicSalary + makan;
        }

        public decimal Makan { get => makan; set => makan = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Bonus = {this.makan.ToString("C", new CultureInfo("id-ID"))} | {this.BasicSalary + this.makan} || Total Salary =  {this.TotalSalaryEmp.ToString("C", new CultureInfo("id-ID"))}";
        }
        
    }
}