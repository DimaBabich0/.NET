using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW26
{
    internal class Program
    {
        static void ShowArr<T>(IEnumerable<T> arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + "; ");
            }
            Console.WriteLine();
        }
        static void ShowArr(IEnumerable<Student> arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item + ";");
            }
        }

        static void Task1()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Array:");
            ShowArr(arr);
            Console.WriteLine();

            #region Task 1
            Console.WriteLine("1. Get elements:");
            var task_EXT = arr.Select(x => x);
            var task_LINQ = from i
                            in arr
                            select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 2
            Console.WriteLine("2. Get elements which is even:");
            task_EXT = arr.Where(x => x % 2 == 0);
            task_LINQ = from i
                        in arr
                        where i % 2 == 0
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 3
            Console.WriteLine("3. Get elements which is odd:");
            task_EXT = arr.Where(x => x % 2 != 0);
            task_LINQ = from i in arr where i % 2 != 0 select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);

            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 4
            Console.WriteLine("4. Get elements which is bigger then user number:");
            Console.Write("Enter number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            task_EXT = arr.Where(x => x > userInput);
            task_LINQ = from i
                        in arr
                        where i > userInput
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);

            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 5
            Console.WriteLine("5. Get elements which is in user range:");
            Console.Write("Enter start of the range: ");
            int startRange = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end of the range: ");
            int endRange = Convert.ToInt32(Console.ReadLine());

            task_EXT = arr.Where(x => x > startRange && x < endRange);
            task_LINQ = from i
                        in arr
                        where i > startRange && i < endRange
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);

            Console.WriteLine("--------------------------------------------");
            #endregion

            int[] arr2 = new int[16];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = i + 1;
            }
            Console.WriteLine("Array:");
            ShowArr(arr2);

            #region Task 6
            Console.WriteLine("6. Get elements which is multiplied by \"7\" and sorted by ascending:");
            task_EXT = arr2.Where(x => x % 7 == 0).OrderBy(x => x);
            task_LINQ = from i
                        in arr2
                        where i % 7 == 0
                        orderby i ascending
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);

            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 7
            Console.WriteLine("6. Get elements which is multiplied by \"8\" and sorted by decreasing:");
            task_EXT = arr2.Where(x => x % 8 == 0).OrderByDescending(x => x);
            task_LINQ = from i
                        in arr2
                        where i % 8 == 0
                        orderby i descending
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);

            Console.WriteLine("--------------------------------------------");
            #endregion
        }

        static void Task2()
        {
            string[] arr = { "Kyiv", "Amsterdam", "Birmingham", "Dublin", "London", "New Delhi", "Paris", "Mexico", "New-York" };
            Console.WriteLine("Array:");
            ShowArr(arr);
            Console.WriteLine();

            #region Task 1
            Console.WriteLine("1. Get elements:");
            var task_EXT = arr.Select(x => x);
            var task_LINQ = from i
                            in arr
                            select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 2
            Console.WriteLine("2. Get elements by length:");
            Console.Write("Enter the length of the city name: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            task_EXT = arr.Where(x => x.Length == userInput);
            task_LINQ = from i
                        in arr
                        where i.Length == userInput
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 3
            Console.WriteLine("3. Get elements which starts with \"A\":");
            task_EXT = arr.Where(x => x.ToUpper().StartsWith("A"));
            task_LINQ = from i
                        in arr
                        where i.ToUpper().StartsWith("A")
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 4
            Console.WriteLine("4. Get elements which ends with \"M\":");
            task_EXT = arr.Where(x => x.ToUpper().EndsWith("M"));
            task_LINQ = from i
                        in arr
                        where i.ToUpper().EndsWith("M")
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 5
            Console.WriteLine("5. Get elements which starts with \"N\" and ends with \"K\":");
            task_EXT = arr.Where(x => x.ToUpper().StartsWith("N") && x.ToUpper().EndsWith("K"));
            task_LINQ = from i
                        in arr
                        where i.ToUpper().StartsWith("N") && i.ToUpper().EndsWith("K")
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 6
            Console.WriteLine("6. Get elements which starts with \"Ne\" and order by descending:");
            task_EXT = arr.Where(x => x.ToUpper().StartsWith("NE")).OrderByDescending(x => x);
            task_LINQ = from i
                        in arr
                        where i.ToUpper().StartsWith("NE")
                        orderby i descending
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Institution { get; set; }

            public Student(string firstName, string lastName, int age, string institution)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Institution = institution;
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName}, {Age}, \"{Institution}\"";
            }
        }
        static void Task3()
        {
            Student[] arr = {
                new Student("Larry", "Torres", 21, "Oxford"),
                new Student("Daniel", "Brocki", 23, "MIT"),
                new Student("Angelia", "Burton", 18, "Oxford"),
                new Student("Chris", "Mccall", 19, "MIT"),
                new Student("Boris", "Holt", 22, "Oxford")
            };

            Console.WriteLine("Array:");
            ShowArr(arr);
            Console.WriteLine();

            #region Task 1
            Console.WriteLine("1. Get elements:");
            var task_EXT = arr.Select(x => x);
            var task_LINQ = from i
                            in arr
                            select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 2
            Console.WriteLine("2. Get elements with first name \"Boris\":");
            task_EXT = arr.Where(x => x.FirstName.ToUpper() == "BORIS");
            task_LINQ = from i
                        in arr
                        where i.FirstName.ToUpper() == "BORIS"
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 3
            Console.WriteLine("3. Get elements which last name begin with \"Bro\":");
            task_EXT = arr.Where(x => x.LastName.ToUpper().StartsWith("BRO"));
            task_LINQ = from i
                        in arr
                        where i.LastName.ToUpper().StartsWith("BRO")
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 4
            Console.WriteLine("4. Get elements which age more then \"19\":");
            task_EXT = arr.Where(x => x.Age > 19);
            task_LINQ = from i
                        in arr
                        where i.Age > 19
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 5
            Console.WriteLine("5. Get elements which age more then \"20\" and less then \"23\":");
            task_EXT = arr.Where(x => x.Age > 20 && x.Age < 23);
            task_LINQ = from i
                        in arr
                        where i.Age > 20 && i.Age < 23
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 6
            Console.WriteLine("6. Get elements which institution is \"MIT\":");
            task_EXT = arr.Where(x => x.Institution.ToUpper() == "MIT");
            task_LINQ = from i
                        in arr
                        where i.Institution.ToUpper() == "MIT"
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region Task 7
            Console.WriteLine("7. Get elements which institution is \"Oxford\" and age more then \"18\" sorted by descending:");
            task_EXT = arr.Where(x => x.Institution.ToUpper() == "OXFORD" && x.Age > 18).OrderByDescending(x => x.Age);
            task_LINQ = from i
                        in arr
                        where i.Institution.ToUpper() == "OXFORD" && i.Age > 18
                        orderby i.Age descending
                        select i;

            Console.WriteLine("Extention method:");
            ShowArr(task_EXT);
            Console.WriteLine("LINQ:");
            ShowArr(task_LINQ);
            Console.WriteLine("--------------------------------------------");
            #endregion

        }

        static void Main()
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
