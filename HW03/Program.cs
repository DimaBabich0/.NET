using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03
{
    internal class Program
    {
        static void Task1()
        {
            int[] arr = new int[10];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 10);
            }

            Console.WriteLine("Array:");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            int even = 0;
            int odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) { even++; } else { odd++; }
            }
            Console.WriteLine($"Number of odd elements: {odd}");
            Console.WriteLine($"Number of even elements: {even}");

            Array.Sort(arr);
            int unique = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    unique++;
                }
            }
            Console.WriteLine($"Number of unique elements: {unique}");
        }
        static void Task2()
        {
            int min, max, num;

            Console.Write("Enter start of range: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end of range: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number to compare: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] arr = new int[10];
            Random r = new Random();
            int numElem = 0;
            Console.WriteLine("Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(min, max);
                Console.Write($"{arr[i]} ");
                if (arr[i].CompareTo(num) <= 0) { numElem++; }
            }
            Console.WriteLine();

            Console.WriteLine($"The number of elements that are less than {num} is: {numElem}");
        }
        static void Task3()
        {
            int[] arr = new int[10];
            Random r = new Random();
            Console.WriteLine("Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 9);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            int[] digits = new int[3];
            Console.WriteLine("Enter 3 digits:");
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = Convert.ToInt32(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i <= arr.Length - 3; i++)
            {
                if (arr[i] == digits[0] && arr[i + 1] == digits[1] && arr[i + 2] == digits[2])
                {
                    count++;
                }
            }

            Console.WriteLine($"Sequence {string.Join(" ", digits)} occurs {count} times in the array");
        }
        static void Task4()
        {
            Random r = new Random();

            int[] arr1 = new int[r.Next(5, 15)];
            int[] arr2 = new int[r.Next(5, 15)];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = r.Next(0, 10);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = r.Next(0, 10);
            }

            int[] biggerArr = arr1.Length > arr2.Length ? arr1 : arr2;
            int[] smallerArr = arr1.Length < arr2.Length ? arr1 : arr2;

            int[] arr3 = new int[biggerArr.Length];
            int index = 0;

            for (int i = 0; i < biggerArr.Length ; i++)
            {
                bool isCommon = false;

                for (int j = 0; j < smallerArr.Length; j++)
                {
                    if (biggerArr[i] == smallerArr[j])
                    {
                        isCommon = true;
                        break;
                    }
                }
                if (isCommon && (Array.IndexOf(arr3, biggerArr[i])) < 0)
                {
                    arr3[index++] = biggerArr[i];
                }
            }

            Console.WriteLine("Array 1:");
            foreach (int i in arr1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("Array 2:");
            foreach (int i in arr2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("Array 3:");
            foreach (int i in arr3)
            {
                if (i != 0)
                {
                    Console.Write($"{i} ");
                }
                else { break; }
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}
