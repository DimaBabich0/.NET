using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateBirthday { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string[] Duties { get; set; }

        public Employee() { }
        public Employee(string name, int age, DateTime dateBirthday, string jobTitle, string phoneNumber, string email, string[] duties)
        {
            Name = name;
            Age = age;
            DateBirthday = dateBirthday;
            JobTitle = jobTitle;
            PhoneNumber = phoneNumber;
            Email = email;
            Duties = duties;
        }
        public void InputData()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter age: ");
            try
            {
                Age = int.Parse(Console.ReadLine());
                throw new FormatException("You entered the age incorrectly");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Age = 18;
            }

            Console.Write("Enter phone mumber: ");
            PhoneNumber = Console.ReadLine();

            Console.Write("Enter email: ");
            Email = Console.ReadLine();

            Console.Write("Enter job title: ");
            JobTitle = Console.ReadLine();

            Console.Write("Enter date of Birth (yyyy.mm.dd): ");
            try
            {
                DateBirthday = DateTime.Parse(Console.ReadLine());
                throw new FormatException("You entered the date incorrectly");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                DateBirthday = DateTime.Now;
            }

            Console.Write("Enter duties (\"space\" to separate): ");
            Duties = Console.ReadLine().Trim().Split(' ');
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\tEmployee information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Date of birthday: {DateBirthday.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Job title: {JobTitle}");
            Console.WriteLine($"Phone: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");

            if (Duties != null && Duties.Length > 0)
            {
                Console.WriteLine("Duties:");
                for (int i = 0; i < Duties.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Duties[i]}");
                }
            }
            else
            {
                Console.WriteLine("Duties: no duties");
            }
            Console.WriteLine();
        }
    }
}
