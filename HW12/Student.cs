using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    internal class Student : Person
    {
        private double _average;
        private string _number_of_group;

        public double Average
        {
            get { return _average; }
            set { _average = value; }
        }
        public string NumberOfGroup
        {
            get { return _number_of_group; }
            set { _number_of_group = value; }
        }

        public Student() : base() { Average = 0; NumberOfGroup = "Empty"; }
        public Student(string name, string surname, int age, string phone, double average, string number_of_group)
            : base(name, surname, age, phone)
        {
            Average = average;
            NumberOfGroup = number_of_group;
        }

        new public void Print()
        {
            base.Print();
            Console.WriteLine("\tStudent info:");
            Console.WriteLine($"Average: {Average}");
            Console.WriteLine($"NumberOfGroup: {NumberOfGroup}");
        }
    }
}
