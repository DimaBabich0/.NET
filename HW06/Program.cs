using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW06.MyDate;

namespace HW06
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Date #1:");
            MyDate date1 = new MyDate();
            date1.ShowDate();
            Console.WriteLine();

            Console.WriteLine("Date #2:");
            MyDate date2 = new MyDate(10, 10, 2024);
            date2.ShowDate();
            date2.ShowDifference(date1);
            Console.WriteLine();

            Console.WriteLine("Date #3:");
            MyDate date3 = new MyDate(31, 2, 2024);
            date3.ShowDate();
            Console.WriteLine();

            Console.WriteLine("Date #4:");
            MyDate date4 = new MyDate();
            date4.ShowDate();
            date4.ChangeForwardDays(10);
            date4.ShowDate();
            date4.ChangeBackDays(5);
            date4.ShowDate();
            Console.WriteLine();

            Console.WriteLine("Date #5:");
            MyDate date5 = new MyDate(1, 1, 2024);
            date5.ShowDate();
            Console.WriteLine(date5.Day_Of_Week);
        }
    }
}
