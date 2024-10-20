using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW09.MyDate;

namespace HW09
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Date #1:");
            MyDate date1 = new MyDate();
            date1.ShowDate();
            Console.WriteLine();

            Console.WriteLine("Trying change day to \"-1\":");
            date1.Day = -1;
            date1.ShowDate();
            Console.WriteLine();

            Console.WriteLine("Trying change month to \"13\":");
            date1.Month = -1;
            date1.ShowDate();
            Console.WriteLine();

            Console.WriteLine("Trying change year to \"-100\":");
            date1.Year = -100;
            date1.ShowDate();
            Console.WriteLine();
        }
    }
}
