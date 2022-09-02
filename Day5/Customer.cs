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

        public override decimal TotalIncome(Dictionary<string, decimal> data)
        {
            throw new NotImplementedException();
        }
    }
}
