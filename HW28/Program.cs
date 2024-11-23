using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW28
{
    internal class Program
    {
        static void Main()
        {
            List<Phone> phones = new List<Phone>()
            {
                new Phone("Galaxy S20", "Samsung", 999, new DateTime(2020, 2, 11)),
                new Phone("iPhone 11", "Apple", 699, new DateTime(2019, 9, 20)),
                new Phone("Mi 11", "Xiaomi", 749, new DateTime(2021, 1, 1)),
                new Phone("Pixel 5", "Google", 699, new DateTime(2020, 9, 30)),
                new Phone("Galaxy Note 20", "Samsung", 949, new DateTime(2020, 8, 21)),
                new Phone("iPhone SE (2020)", "Apple", 399, new DateTime(2020, 4, 24)),
                new Phone("Redmi Note 9", "Xiaomi", 99, new DateTime(2020, 4, 30)),
                new Phone("Pixel 4a", "Google", 349, new DateTime(2020, 8, 20)),
                new Phone("Galaxy A52", "Samsung", 499, new DateTime(2021, 3, 17)),
                new Phone("iPhone XR", "Apple", 499, new DateTime(2018, 10, 26))
            };

            #region Task 1
            Console.Write("1. Count the number of phones: ");
            var res = phones.Select(p => p).Count();
            Console.WriteLine(res);
            Console.WriteLine();

            Console.Write("2. Count the number of phones with a price over 100: ");
            res = phones.Where(p => p.Price > 100).Count();
            Console.WriteLine(res);
            Console.WriteLine();

            Console.Write("3. Count the number of phones with prices ranging from 400 to 700: ");
            res = phones.Where(p => p.Price > 400 && p.Price < 700).Count();
            Console.WriteLine(res);
            Console.WriteLine();

            Console.Write("4. Count the number of specific phones manufacturer (Apple): ");
            res = phones.Where(p => p.Manufacturer == "Apple").Count();
            Console.WriteLine(res);
            Console.WriteLine();

            Console.WriteLine("5. Find phone with the lowest price:");
            var res2 = phones.OrderBy(p => p.Price).First();
            Console.WriteLine(res2);
            Console.WriteLine();

            Console.WriteLine("6. Find the phone with the expensive price:");
            res2 = phones.OrderByDescending(p => p.Price).First();
            Console.WriteLine(res2);
            Console.WriteLine();

            
            Console.WriteLine("7. Show the information about the oldest phone:");
            res2 = phones.OrderBy(p => p.ReleaseDate).First();
            Console.WriteLine(res2);
            Console.WriteLine();

            Console.WriteLine("8. Show the latest phone information:");
            res2 = phones.OrderByDescending(p => p.ReleaseDate).First();
            Console.WriteLine(res2);
            Console.WriteLine();

            Console.WriteLine("9. Find the average phone price:");
            var res3 = phones.Average(p => p.Price);
            Console.WriteLine(res3);
            Console.WriteLine();
            #endregion

            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            #region Task 2
            Console.WriteLine("1. Show the 5 most expensive phones:");
            var res4 = phones.OrderByDescending(p => p.Price).Take(5);
            foreach (var item in res4)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.WriteLine("2. Show the 5 cheapest phones:");
            res4 = phones.OrderBy(p => p.Price).Take(5);
            foreach (var item in res4)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.WriteLine("3. Show the 3 oldest phones:");
            res4 = phones.OrderBy(p => p.ReleaseDate).Take(3);
            foreach (var item in res4)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.WriteLine("4. Show the 3 newest phones:");
            res4 = phones.OrderByDescending(p => p.ReleaseDate).Take(3);
            foreach (var item in res4)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            #endregion

            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            
            #region Task 3
            Console.WriteLine("1. Show statistics on the number of phones of each manufacturer:");
            var stats1 = phones
                  .GroupBy(p => p.Manufacturer)
                  .Select(g => new { Manufacturer = g.Key, Count = g.Count() });
            foreach (var item in stats1)
            {
                Console.WriteLine($"{item.Manufacturer}: {item.Count}");
            }
            Console.WriteLine();

            Console.WriteLine("2. Show statistics on the number of phone models:");
            var stats2 = phones
                    .GroupBy(p => p.Title.Split(' ')[0])
                    .Select(g => new { Model = g.Key, Count = g.Count() });
            foreach (var item in stats2)
            {
                Console.WriteLine($"{item.Model}: {item.Count}");
            }
            Console.WriteLine();

            Console.WriteLine("3. Show statistics of phone by year:");
            var stats3 = phones
                .GroupBy(p => p.ReleaseDate.Year)
                .Select(g => new { Year = g.Key, Count = g.Count() });
            foreach (var item in stats3)
            {
                Console.WriteLine($"{item.Year}: {item.Count}");
            }
            Console.WriteLine();
            #endregion
        }
    }
}
