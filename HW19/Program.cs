using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW19.Program.Task1;

namespace HW19
{
    class Program
    {
        internal class Task1
        {
            public delegate void GetRGB(string color);
            
            public void Run()
            {
                GetRGB getRGB = delegate (string color)
                {
                    int r, g, b;
                    switch (color.Trim().ToLower())
                    {
                        case "black": (r, g, b) = (0, 0, 0); break;
                        case "white": (r, g, b) = (255, 255, 255); break;
                        case "red": (r, g, b) = (255, 0, 0); break;
                        case "green": (r, g, b) = (0, 255, 0); break;
                        case "blue": (r, g, b) = (0, 0, 255); break;
                        case "orange": (r, g, b) = (255, 165, 0); break;
                        case "yellow": (r, g, b) = (255, 255, 0); break;
                        case "purple": (r, g, b) = (128, 0, 128); break;
                        case "pink": (r, g, b) = (255, 0, 255); break;
                        case "gray": (r, g, b) = (128, 128, 128); break;
                        default:
                            Console.WriteLine("Color not found");
                            return;
                    }

                    Console.WriteLine($"Color: {color.Trim()}, RGB: ({r}, {g}, {b})");
                };

                Console.WriteLine("Enter color:");
                string input = Console.ReadLine();
                getRGB(input);
            }
        }

        internal class Task2
        {
            public void Run()
            {
                List<Item> items1 =
                [
                    new("Bottle of water", 1, 2),
                    new("Laptop", 2.5, 6),
                    new("Laptop charging", 0.5, 1),
                    new("Bar of chocolate", 0.3, 0.5),
                    new("Notebook", 0.5, 1),
                    new("Pen", 0.1, 0.2)
                ];

                double weight = 0.0;
                foreach (Item item in items1)
                {
                    weight += item.Weight;
                }

                Backpack backpack = new Backpack("Grey", "Under Armour", "Canvas", items1.Sum(obj => obj.Weight), 20, items1);
                backpack.PrintInfo();

                Item obj1 = new Item("Book", 1, 6);
                backpack.AddObject(obj1);
                backpack.PrintInfo();

                Item obj2 = new Item("Headphones", 0.6, 4);
                backpack.AddObject(obj2);
                backpack.PrintInfo();
            }
        }

        internal class Task3
        {
            public delegate int CountArrayNumbers(int[] arr);

            public void Run()
            {
                int[] numbers = { 10, 5, 7, 3, 6, 14, 21};
                CountArrayNumbers countMultiples = delegate (int[] arr)
                {
                    int count = 0;
                    foreach (int num in arr)
                    {
                        if (num % 7 == 0)
                        {
                            count++;
                        }
                    }
                    return count;
                };

                int count = countMultiples(numbers);
                Console.WriteLine(string.Join(" ", numbers));
                Console.WriteLine($"Number of elements divisible by \"7\": {count}");
            }
        }

        internal class Task4
        {
            public delegate int CountPositiveNumbers(int[] arr);

            public void Run()
            {
                int[] numbers = { 5, -2, 1, 3, -7, 6 };
                CountPositiveNumbers countPosNumbers = delegate (int[] arr)
                {
                    int count = 0;
                    foreach (int num in arr)
                    {
                        if (num > 0)
                        {
                            count++;
                        }
                    }
                    return count;
                };

                int posCount = countPosNumbers(numbers);
                Console.WriteLine(string.Join(" ", numbers));
                Console.WriteLine($"Number of positive elements: {posCount}");
            }
        }

        internal class Task5
        {
            public delegate void GetUniqueNeg(int[] arr);

            public void Run()
            {
                int[] numbers = { -3, -4, -3, -5, -6, -4 };

                GetUniqueNeg getUniqueNeg = arr =>
                {
                    var uniqueNegatives = arr.Where(num => num < 0).Distinct();
                    Console.Write("Distinct negative numbers: ");
                    foreach (int num in uniqueNegatives)
                    {
                        Console.Write($"{num}, ");
                    }
                    Console.WriteLine();
                };

                Console.WriteLine(string.Join(" ", numbers));
                getUniqueNeg(numbers);
            }
        }

        internal class Task6
        {
            public delegate bool GetWord(string str, string word);

            public void Run()
            {
                string text = "Hello world";
                string word = "World";

                GetWord containsWord = (text, word) => text.Contains(word.Trim().ToLower());
                bool result = containsWord(text, word);
                Console.WriteLine($"Does the word \"{word}\" in the text \"{text}\": {result}");
            }
        }


        static void Main()
        {
            Task1 task1 = new Task1();
            task1.Run();

            Task2 task2 = new Task2();
            task2.Run();

            Task3 task3 = new Task3();
            task3.Run();

            Task4 task4 = new Task4();
            task4.Run();

            Task5 task5 = new Task5();
            task5.Run();

            Task6 task6 = new Task6();
            task6.Run();
        }
    }
}
