using Day5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Customer : Person
    {
        private string accountNumber;
        public Customer(string firstName, string lastName, string email, DateTime birthDay, string accountNumber) : base(firstName, lastName, email, birthDay)
        {
            SocialNumber = new Random().Next(1000, 1100);
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            this.accountNumber = accountNumber;
        }

        public string AccountNumber { get => accountNumber; set => accountNumber = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Account Number : {this.accountNumber}";
        }

        public override decimal TotalIncome(Dictionary<string, decimal> data)
        {
            var totalIncome = 0M;

            foreach (var item in data)
            {
                totalIncome += item.Value;
            }
            return totalIncome;
        }
    }
}
