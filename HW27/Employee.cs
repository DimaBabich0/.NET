using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW27
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

        public Employee(string firstName, string lastName, string position, string phoneNumber, string email, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            PhoneNumber = phoneNumber;
            Email = email;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName};\n" +
                $"Position: {Position};\n" +
                $"Phone number: {PhoneNumber};\n" +
                $"Email: {Email};\n" +
                $"Salary: {Salary};";
        }
    }
}
