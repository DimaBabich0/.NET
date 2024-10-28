using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    internal class MyArray : ICalc, IOutput, ICalc2
    {
        public int Size { get; }
        public int[] Array { get; set; }
        private readonly static Random rnd = new Random();

        public MyArray(int size)
        {
            Size = size;
            Array = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                Array[i] = rnd.Next(0, 11);
            }
        }

        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine();
        }

        public int Less(int valueToCompare)
        {
            int count = 0;

            for (int i = 0; i < Size; i++)
            {
                if (Array[i] < valueToCompare)
                    count++;
            }

            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;

            for (int i = 0; i < Size; i++)
            {
                if (Array[i] > valueToCompare)
                    count++;
            }

            return count;
        }
        
        public int CountDistinct()
        {
            int count = 0;
            bool isDistinct;

            for (int i = 0; i < Size; i++)
            {
                isDistinct = true;
                for (int j = 0; j < i; j++)
                {
                    if (Array[i] == Array[j])
                    {
                        isDistinct = false;
                        break;
                    }
                }
                if (isDistinct)
                    count++;
            }

            return count;
        }

        public int EqualToValue(int value)
        {
            int count = 0;
            for (int i = 0; i < Size; i++)
            {
                if (Array[i] == value)
                    count++;
            }
            return count;
        }

        public void ShowOdd()
        {
            for (int i = 0; i < Size; i++)
            {
                if (Array[i] % 2 == 1)
                    Console.Write(Array[i] + " ");
            }
        }

        public void ShowEven()
        {
            for (int i = 0; i < Size; i++)
            {
                if (Array[i] % 2 == 0)
                    Console.Write(Array[i] + " ");
            }
        }
    }
}
