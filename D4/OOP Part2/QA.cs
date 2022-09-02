using System;
using System.Collections.Generic;
using System.Globalization;

namespace Day4.OOP_Part2
{
    internal class QA : Employee
    {
        private decimal makan;

        public QA(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal makan) : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Makan = makan;
            this.Role = "QA";
            TotalSalaryEmp = basicSalary + makan;
        }

        public decimal Makan { get => makan; set => makan = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Makan = {this.makan.ToString("C", new CultureInfo("id-ID"))}";
        }

    }
}