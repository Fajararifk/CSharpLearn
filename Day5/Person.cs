using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal abstract class Person
    {
        private int socialNumber;
        private string firstName;
        private string lastName;
        private string email;
        private DateTime birthDay;
        private decimal totalRevenue;

        protected Person(string firstName, string lastName, string email, DateTime birthDay)
        {
            /*this.socialNumber = socialNumber;*/
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthDay = birthDay;
        }

        public int SocialNumber { get => socialNumber; set => socialNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }

        public override string? ToString()
        {
            return $"Social Number : {this.socialNumber} | FullName : {this.firstName} {this.lastName} | Email : {this.email} | BirthDate : {this.birthDay} | Total Revenue : {this.totalRevenue}";
        }

        public abstract decimal TotalIncome(Dictionary<string, decimal> data);
    }
}
