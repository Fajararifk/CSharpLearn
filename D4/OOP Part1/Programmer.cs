using System;
using System.Collections.Generic;
using System.Globalization;

namespace D4.PartOne
{
    internal class Programmer : Employee
    {
        private decimal transportasi;

        public Programmer(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal transportasi)
            : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Transportasi = transportasi;
            this.Role = "Programmer";
            TotalSalaryEmp = basicSalary + transportasi;
        }

        public decimal Transportasi { get => transportasi; set => transportasi = value; }



        public override string? ToString()
        {
            return $"{base.ToString()} | TunjanganTransportasi = {this.transportasi.ToString("C",new CultureInfo("id-ID"))} | {this.BasicSalary+this.transportasi} || Total Salary =  {this.TotalSalaryEmp.ToString("C", new CultureInfo("id-ID"))}\n";
        }
    }
}