using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW27
{
    internal class Program
    {
        static void Main()
        {
            var employees1 = new List<Employee> {
                new Employee("Jane", "Smith", "Sales Representative", "+987654321", "jane.smith@example.com", 55000),
                new Employee("Lionel", "Johnson", "Software Developer", "+233123123", "lionel.johnson@example.com", 80000),
                new Employee("Emily", "Davis", "Marketing Specialist", "+456456456", "emily.davis@example.com", 60000),
                new Employee("Dima", "Brown", "Data Analyst", "+789789789", "dima.brown@example.com", 70000),
                new Employee("Jessica", "Taylor", "HR Manager", "+321321321", "jessica.taylor@example.com", 65000),
                new Employee("Sophia", "Clark", "Customer Support", "+777888999", "sophia.clark@example.com", 50000)
            };

            var employees2 = new List<Employee>
            {
                new Employee("Lionel", "Anderson", "Product Manager", "+654654654", "lionel.anderson@example.com", 85000),
                new Employee("Elizabeth", "Martinez", "Financial Analyst", "+231222333", "elizabeth.martinez@example.com", 73000),
                new Employee("James", "Harris", "Quality Assurance Engineer", "+333444555", "james.harris@example.com", 68000)
            };

            var companies = new List<Company>
            {
                new Company("White FoodCo", new DateTime(2020, 7, 4), "Devilery", "255 Albert Road, London", "Doug Black White", employees1),
                new Company("Marketing Solutions", new DateTime(2023, 7, 5), "Marketing", "Bellevue, Washington, U.S.", "Liliana Paolo", employees2),
            };

            Console.WriteLine("\tPart 1:");
            var res1 = from c
                        in companies
                        select c;
            Console.WriteLine("1. Get information about all companies");
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            res1 = from c
                    in companies
                    where c.Title.Contains("Food")
                    select c;
            Console.WriteLine("2. Get companies that have the word \"Food\" in their names");
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            res1 = from c
                    in companies
                    where c.Profile == "Marketing"
                    select c;
            Console.WriteLine("3. Get companies that work in the field of marketing");
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            res1 = from c
                    in companies
                    where c.Profile == "Marketing" || c.Profile == "IT"
                    select c;
            Console.WriteLine("4. Get firms that work in the field of marketing or IT");
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            res1 = from c
                    in companies
                    where c.Employees.Count > 5
                    select c;
            Console.WriteLine("5. Get firms with more than 5 employees");
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            res1 = from c
                    in companies
                    where c.Address.Contains("London")
                    select c;
            Console.WriteLine("6. Get firms that are located in London");
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            res1 = from c
                    in companies
                    where c.DirectorName.Contains("White")
                    select c;
            Console.WriteLine("7. Get firms with the last name of director \"White\"");
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            res1 = from c in companies
                    where c.DirectorName.Contains("Black") && c.DirectorName.Contains("White")
                    select c;
            Console.WriteLine("8. Get firms whose director name is \"Black\" and whose title contains the word \"White\"");
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();



            Console.WriteLine("\n\tPart 2:");
            var comp_name = "White FoodCo";
            var res2 = from c in companies
                         where c.Title == comp_name
                         from e in c.Employees
                         select e;
            Console.WriteLine($"1. Get all employees of a particular company ({comp_name})");
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var salary = 70000;
            res2 = from c in companies
                     where c.Title == comp_name
                     from e in c.Employees
                     where e.Salary > salary
                     select e;
            Console.WriteLine($"2. Get {comp_name} employees with a salary of more than {salary}");
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            res2 = from c in companies
                     from e in c.Employees
                     where e.Position.Contains("Manager")
                     select e;
            Console.WriteLine($"3. Get employees of all firms with a manager position");
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            res2 = from c in companies
                     from e in c.Employees
                     where e.PhoneNumber.StartsWith("+23")
                     select e;
            Console.WriteLine($"4. Get employees whose phone number starts with \"+23\"");
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            res2 = from c in companies
                     from e in c.Employees
                     where e.Email.ToLower().StartsWith("di")
                     select e;
            Console.WriteLine($"5. Get employees whose email starts with \"di\"");
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            res2 = from c in companies
                     from e in c.Employees
                     where e.FirstName == "Lionel"
                     select e;
            Console.WriteLine($"6. Get employees with the name \"Lionel\"");
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
