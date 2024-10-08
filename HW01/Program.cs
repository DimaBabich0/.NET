using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");
        }
        static void Task2()
        {
            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int mult = 1;

            Console.WriteLine("Write 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                min = num < min ? num : min;
                max = num > max ? num : max;
                mult = num * mult;
            }
            Console.WriteLine($"Sum: {sum}; Min: {min}; Max: {max}; Mult: {mult}");
        }
        static void Task3()
        {
            bool isSixDigit = false;
            string str = "";

            while (!isSixDigit)
            {
                Console.Write("Enter a six-digit number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                str = Convert.ToString(num);
                if (str.Length == 6) isSixDigit = true;
                else Console.WriteLine("You did not enter a six-digit number. Try again.");
            }

            string reverse = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            Console.WriteLine($"Normal number: {str}");
            Console.WriteLine($"Reverse number: {reverse}");
        }
        static void Task4()
        {
            Console.Write("Enter the start of the range: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end of the range: ");
            int end = Convert.ToInt32(Console.ReadLine());
            if (start > end)
            {
                Console.WriteLine("Start is more than end of range");
                return;
            }

            int a = 0, b = 1;
            if (start <= 0)
            {
                Console.Write($"{a} ");
            }
            while (b <= end)
            {
                if (b >= start)
                {
                    Console.Write($"{b} ");
                }
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }
        static void Task5()
        {
            Console.Write("Enter the start of the range: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end of the range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start > end)
            {
                Console.WriteLine("Start is more than end of range");
                return;
            }

            for (int i = start; i <= end; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int num = i;
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
        static void Task6()
        {
            Console.Write("Enter the length of the line: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter the character to fill in the line: ");
            char symbol = char.Parse(Console.ReadLine());

            Console.Write("Enter the direction of the line (horizontal/vertical): ");
            string direction = Console.ReadLine().ToLower();

            if (direction == "horizontal")
            {
                for (int i = 0; i < length; i++) Console.Write(symbol);
            }
            else if (direction == "vertical")
            {
                for (int i = 0; i < length; i++) Console.WriteLine(symbol);
            }
            else
            {
                Console.WriteLine("Wrong direction. Enter \"horizontal\" or \"vertical\"");
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
        }
    }
}
