using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    internal class Academy_Group
    {
        private Student[] _students;
        private int _count;

        public Academy_Group() 
        {
            _students = new Student[1];
            _count = 0;
        }

        public void Add(Student student)
        {
            Student[] temp = _students;
            _students = new Student[_count + 1];
            for (int i = 0; i < _students.Length - 1; i++)
            {
                _students[i] = temp[i];
            }
            _students[_count] = student;
            _count++;
        }

        public void Remove(string surname)
        {
            Student[] temp = new Student[_students.Length - 1];
            int indexForTemp = 0;
            bool isFind = false;

            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Surname.ToLower() != surname.ToLower())
                {
                    temp[indexForTemp++] = _students[i];
                }
                else isFind = true;
            }

            if(isFind)
            {
                _students = temp;
                _count--;
                Console.WriteLine($"Student with surname \"{surname}\" is deleted from array");
            }
            else Console.WriteLine($"Student with surname \"{surname}\" is not in the array");
        }

        public void Edit(string surname)
        {
            int index = -1;
            Student student = new Student();

            for (int i = 0; i < _count; i++)
            {
                if (_students[i].Surname.ToLower() == surname.ToLower())
                {
                    student = _students[i];
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                student.Print();
                Console.WriteLine();

                string str;
                Console.WriteLine("Write new data for student (just press \"Enter\" if you don't want change data):");
               
                Console.Write($"Name: {student.Name}; New data: ");
                str = Console.ReadLine();
                student.Name = (string.IsNullOrEmpty(str) ? student.Name : str);

                Console.Write($"Surname: {student.Surname}; New data: ");
                str = Console.ReadLine();
                student.Surname = (string.IsNullOrEmpty(str) ? student.Surname : str);

                Console.Write($"Age: {student.Age}; New data: ");
                str = Console.ReadLine();
                student.Age = (string.IsNullOrEmpty(str) ? student.Age : Convert.ToInt32(str));

                Console.Write($"Phone: {student.Phone}; New data: ");
                str = Console.ReadLine();
                student.Phone = (string.IsNullOrEmpty(str) ? student.Phone : str);

                Console.Write($"Average: {student.Average}; New data: ");
                str = Console.ReadLine();
                student.Average = (string.IsNullOrEmpty(str) ? student.Average : Convert.ToDouble(str));

                Console.Write($"Number of group: {student.NumberOfGroup}; New data: ");
                str = Console.ReadLine();
                student.NumberOfGroup = (string.IsNullOrEmpty(str) ? student.NumberOfGroup : str);
            }
            else Console.WriteLine($"Student with surname \"{surname}\" is not in the array");
        }

        public void Print()
        {
            if (_count == 0)
            {
                Console.WriteLine("Array is empty");
                return;
            }

            Console.WriteLine("Array of students:");
            for (int i = 0; i < _students.Length; i++)
            {
                Console.WriteLine($"\tStudent #{i + 1}");
                _students[i].Print();
                Console.WriteLine();
            }
        }

        public void Save()
        {
            Console.WriteLine("File of students is saved");
        }

        public void Load()
        {
            Console.WriteLine("File of students is loaded");
        }

        public void Search(double average)
        {
            Console.WriteLine("Search by average:");
            foreach (var student in _students)
            {
                if (student.Average > average)
                {
                    student.Print();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
