using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW14
{
    internal class Program
    {
        static void Main()
        {
            MyArray arr = new MyArray(15);
            Console.WriteLine("Array:");
            arr.Print();
            Console.WriteLine();

            Console.WriteLine($"Number of elements that are less than \"5\": {arr.Less(5)}");
            Console.WriteLine($"Number of elements that are greater than \"5\": {arr.Greater(5)}");
            Console.WriteLine();

            Console.WriteLine("Even elements of array:");
            arr.ShowEven();
            Console.WriteLine();
            Console.WriteLine("Odd elements of array:");
            arr.ShowOdd();
            Console.WriteLine("\n");

            Console.WriteLine($"Number of unique values in the array: {arr.CountDistinct()}");
            Console.WriteLine();

            Console.WriteLine($"Number of unique values in the array: {arr.CountDistinct()}");
            Console.WriteLine($"Number of elements equal to \"5\": {arr.EqualToValue(5)}");
        }
    }
}
