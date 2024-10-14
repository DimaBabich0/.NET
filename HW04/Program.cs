using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    internal class Program
    {
        static void Task1()
        {
            Random r = new Random();

            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 5);
            }
            Console.WriteLine("Array: " + string.Join(" ", arr));

            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[index++] = arr[i];
                }
            }
            for (int i = index; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
            Console.WriteLine("Changed array: " + string.Join(" ", arr));
        }
        static void Task2()
        {
            int N = 5;

            int[,] matrix = new int[N, N];

            int x = N / 2;
            int y = N / 2;

            matrix[x, y] = 1;
            int value = 2;

            int[,] directions = {
                { 0, -1 },
                { -1, 0 },
                { 0, 1 },
                { 1, 0 }
            };

            int steps = 1;
            int currDirection = 0;

            while (value <= N * N)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < steps; j++)
                    {
                        x += directions[currDirection, 0];
                        y += directions[currDirection, 1];

                        if (x >= 0 && x < N && y >= 0 && y < N)
                        {
                            matrix[x, y] = value++;
                        }
                    }
                    currDirection = (currDirection + 1) % 4;
                }
                steps++;
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(2) + " ");
                }
                Console.WriteLine();
            }
        }
        static void Task3()
        {
            Console.Write("Enter number of rows: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int M = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, M];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }

            Console.WriteLine("Matrix:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadRight(3));
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Enter number of columns to shift: ");
            int shift = int.Parse(Console.ReadLine());

            Console.Write("Enter shift direction (\"left\" or \"right\"): ");
            string dir = Console.ReadLine().ToLower();

            shift = shift % M;

            for (int i = 0; i < N; i++)
            {
                int[] row = new int[M];

                if (dir.ToLower() == "left")
                {
                    for (int j = 0; j < M; j++)
                    {
                        row[j] = matrix[i, (j + shift) % M];
                    }
                }
                else if (dir.ToLower() == "right")
                {
                    for (int j = 0; j < M; j++)
                    {
                        row[(j + shift) % M] = matrix[i, j];
                    }
                }
                else
                {
                    Console.WriteLine("You've entered the wrong direction");
                    return;
                }

                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            Console.WriteLine();

            Console.WriteLine("Changed matrix:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadRight(3));
                }
                Console.WriteLine();
            }
        }
        
        static void Main()
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
