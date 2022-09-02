using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Owner : Person
    {
        private int hasCompany;

        public Owner(string firstName, string lastName, string email, DateTime birthDay, int hasCompany) : base(firstName, lastName, email, birthDay)
        {
            SocialNumber = new Random().Next(1000, 1100);
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            this.hasCompany = hasCompany;
        }

        public int HasCompany { get => hasCompany; set => hasCompany = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | hasCompany : {this.hasCompany}";
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
