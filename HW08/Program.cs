using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static HW08.CreditCard;

namespace HW08
{
    internal class Program
    {
        static void Task1()
        {
            CreditCard card1 = new CreditCard("1234567890123456", "Dima Babich", 123, new DateTime(2026, 2, 1));
            card1.ShowData();
            Console.WriteLine();

            CreditCard card2 = new CreditCard("1234567890123456", "  ", 321, DateTime.Now);
            card2.ShowData();
        }
        static void Task2()
        {
            try
            {
                Console.WriteLine("Enter a mathematical expression for multiplication, for example \"3*2*1*4\":");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    throw new FormatException("You haven't written anything");

                string[] parts = input.Split('*');
                int result = 1;

                foreach (string part in parts)
                {
                    if (!int.TryParse(part.Trim(), out int number))
                        throw new FormatException($"\"{part}\" is not a number");

                    result *= number;
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static void Main()
        {
            Task1();
            Task2();
        }
    }
}
