using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02
{
    internal class Program
    {
        static void Task1()
        {
            int num = 0;
            while (true)
            {
                Console.Write("Enter a number in the range from 1 to 100: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 100 || num < 0)
                {
                    Console.WriteLine("The number entered is not in the range from 1 to 100. Try again.");
                }
                else { break; }
            }

            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else { Console.WriteLine(num); }
        }
        static void Task2() 
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the percentage of the number: ");
            int percent = Convert.ToInt32(Console.ReadLine());

            double result = (double)(num * percent) / 100.0;
            Console.WriteLine($"{percent}% from {num} = {result}");
        }
        static void Task3() 
        {
            int[] digits = new int[4];
            Console.WriteLine("Enter 4 digits:");
            for (int i = 0; i < 4; i++)
            {
                digits[i] = Convert.ToInt32(Console.ReadLine());
            }
            string result = string.Join("", digits);
            Console.WriteLine($"Result: {result}");
        }
        static void Task4() 
        {
            string str = "";
            while (true)
            {
                Console.Write("Enter a six-digit number: ");
                str = Console.ReadLine();
                if (str.Length != 6)
                {
                    Console.WriteLine("You did not enter a six-digit number. Try again.");
                }
                else { break; }
            }

            Console.Write("Enter the first digit to exchange (1 to 6): ");
            int index1 = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("Enter the second digit number to exchange (1 to 6): ");
            int index2 = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index1 < 0 || index1 > 5 || index2 < 0 || index2 > 5)
            {
                Console.WriteLine("Error: the number of steps should be from 1 to 6");
                return;
            }

            char[] digits = str.ToCharArray();
            char temp = digits[index1];
            digits[index1] = digits[index2];
            digits[index2] = temp;

            string result = new string(digits);
            Console.WriteLine($"Result: {result}");
        }
        static void Task5()
        {
            Console.Write("Enter the date (dd.mm.yyyy): ");
            string input = Console.ReadLine();

            DateTime date;
            if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                string dayOfWeek = date.DayOfWeek.ToString();
                string season = "";
                if (date.Month == 12 || date.Month >= 1 && date.Month <= 2) { season = "Winter"; }
                else if (date.Month >= 3 && date.Month <= 5) { season = "Spring"; }
                else if (date.Month >= 6 && date.Month <= 8) { season = "Summer"; }
                else if (date.Month >= 9 && date.Month <= 11) { season = "Autumn"; }
                Console.WriteLine($"{season} {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Error: Date format is not valid. Use the format below: dd.mm.yyyy");
            }
        }
        static void Task6()
        {
            Console.Write("Enter the temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperature converter in:\n1) Fahrenheit\n2) Celsius ");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                double result = temperature * 9 / 5 + 32;
                Console.WriteLine($"{temperature} degrees Celsius by Fahrenheit will be: {Math.Round(result, 2)}");
            }
            else if (answer == 2)
            {
                double result = (temperature - 32) * 5 / 9;
                Console.WriteLine($"{temperature} degrees Fahrenheit by Celsius will be: {Math.Round(result, 2)}");
            }
            else
            {
                Console.WriteLine("You entered the wrong digit");
            }
        }
        static void Task7()
        {
            Console.Write("Enter the start of the range: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end of the range: ");
            int end = Convert.ToInt32(Console.ReadLine());
            
            if (start > end )
            {
                Console.WriteLine("You entered the start and end of the range incorrectly. Numbers have been swapped");
                int temp = start;
                start = end;
                end = temp;
            }

            Console.WriteLine($"List of even numbers between {start} and {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0) Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
        }
    }
}
