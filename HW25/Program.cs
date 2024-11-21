using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW25
{
    internal class Program
    {
        static void Main()
        {
            Money a = new Money(50, 50);
            Money b = new Money(49, 75);

            Console.WriteLine($"A: {a}");
            Console.WriteLine($"B: {b}");

            Money c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");

            Money d = a - b;
            Console.WriteLine($"{a} - {b} = {d}");

            Money mult = a * 2;
            Console.WriteLine($"{a} * 2 = {mult}");

            Money division = b / 2;
            Console.WriteLine($"{b} / 2 = {division}");

            a++;
            Console.WriteLine($"A++: {a}");

            b--;
            Console.WriteLine($"B--: {b}");

            try
            {
                Money e = new Money(0, 1);
                Console.WriteLine($"E: {e}");
                e--;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
