using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW22
{
    internal class Program
    {
        static void Task1()
        {
            EmployeeManager manager = new EmployeeManager();
            string password;

            manager.AddEmployee("Alex123", "HelloWorld");

            password = manager.GetPassword("Alex123");
            if (password != null)
                Console.WriteLine($"Password of employee \"Alex123\": {password}");
            else
                Console.WriteLine("Password of employee \"123\" is missing");

            manager.EditEmployee("Alex123", "alexpassword");

            password = manager.GetPassword("Alex123");
            if (password != null)
                Console.WriteLine($"Password of employee \"Alex123\": {password}");
            else
                Console.WriteLine("Password of employee \"123\" is missing");

            manager.DeleteEmployee("Alex123");
        }

        static void Task2()
        {
            EnglishFrenchDictionary dictionary = new EnglishFrenchDictionary();

            dictionary.AddWord("Hello", "Bonjour");
            dictionary.AddWord("Bye", "Au revoir", "Adieu");

            dictionary.SearchTranslation("Hello");
            dictionary.SearchTranslation("Bye");
            Console.WriteLine();

            dictionary.EditFrenchTranslation("Bye", "Au revoir", "A bientot");
            dictionary.SearchTranslation("Bye");
            Console.WriteLine();

            dictionary.RemoveFrenchTranslation("Bye", "A bientot");
            dictionary.SearchTranslation("Bye");
            Console.WriteLine();

            dictionary.RemoveWord("Bye");
            dictionary.SearchTranslation("Bye");
        }

        static void Task3()
        {
            Cafe cafe = new Cafe();

            cafe.Arrive(new Customer("A", false));
            cafe.Arrive(new Customer("B", true));
            cafe.Arrive(new Customer("C", true));
            cafe.Arrive(new Customer("D", false));
            Console.WriteLine();

            cafe.ServeCustomer();
            cafe.ServeCustomer();
            cafe.ServeCustomer();
            cafe.ServeCustomer();
            cafe.ServeCustomer();
        }

        static void Main()
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
