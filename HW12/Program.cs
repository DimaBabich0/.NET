using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    internal class Program
    {
        Academy_Group obj = new Academy_Group();
        bool isExit = false;

        void WaitToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        void PrintActions()
        {
            Console.WriteLine("\tList of actions:");
            Console.WriteLine("1) Print array");
            Console.WriteLine("2) Add student");
            Console.WriteLine("3) Remove student");
            Console.WriteLine("4) Edit student");
            Console.WriteLine("5) Search students");
            Console.WriteLine("6) Save file");
            Console.WriteLine("7) Load file");
            Console.WriteLine("0) Exit");
            Console.WriteLine();
        }

        void ChooseAction()
        {
            string str;

            while (true)
            {
                Console.Write("Write number of action: ");
                str = Console.ReadLine();
                if (string.IsNullOrEmpty(str) || !(Convert.ToInt32(str) > -1 && Convert.ToInt32(str) < 8))
                {
                    Console.WriteLine("You entered the wrong code. Try again");
                }
                else break;
            }
            switch (Convert.ToInt32(str))
            {
                case 1: obj.Print(); break;
                case 2: AddStudent(); break;
                case 3: RemoveStudent(); break;
                case 4: EditStudent(); break;
                case 5: SeachStudent(); break;
                case 6: obj.Save(); break;
                case 7: obj.Load(); break;
                case 0: isExit = true; break;
            }
        }

        void AddStudent()
        {
            string name, surname, phone, numberOfGroup;
            int age;
            double average;

            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter phone number: ");
            phone = Console.ReadLine();
            Console.Write("Enter average: ");
            average = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number of group: ");
            numberOfGroup = Console.ReadLine();

            Student student = new Student(name, surname, age, phone, average, numberOfGroup);
            obj.Add(student);
        }

        void RemoveStudent()
        {
            string surname;

            Console.Write("Enter surname: ");
            surname = Console.ReadLine();

            if (string.IsNullOrEmpty(surname))
            {
                Console.WriteLine("You enter nothing. Cancel function");
                return;
            }

            obj.Remove(surname);
        }

        void EditStudent()
        {
            string surname;

            Console.Write("Enter surname: ");
            surname = Console.ReadLine();

            if (string.IsNullOrEmpty(surname))
            {
                Console.WriteLine("You enter nothing. Cancel function");
                return;
            }

            obj.Edit(surname);
        }

        void SeachStudent()
        {
            double average;

            Console.Write("Enter average: ");
            average = Convert.ToDouble(Console.ReadLine());

            obj.Search(average);
        }

        static void Main()
        {
            Program program = new Program();
            
            //Some elements for example
            program.obj.Add(new Student
                {
                Name = "Dima",
                Surname = "Babich",
                Age = 19,
                Phone = "+38066002123",
                Average = 11.6,
                NumberOfGroup = "KNP-221"
            });
            program.obj.Add(new Student());
            program.obj.Add(new Student
            {
                Name = "Alex",
                Surname = "Bowey",
                Age = 21,
                Phone = "+38063505041",
                Average = 11.8,
                NumberOfGroup = "KNP-222"
            });

            while (!program.isExit)
            {
                try
                {
                    program.PrintActions();
                    program.ChooseAction();
                }
                catch (Exception ex)
                { 
                    Console.WriteLine($"Error: {ex.Message}");
                }
                program.WaitToContinue();
                Console.Clear();
            }
            Console.WriteLine("Thank you for using our programm");
        }
    }
}
