using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07
{
    internal class Airplane
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        

        public Airplane() { }
        public Airplane(string name, string manufacturer, string type, int year)
        {
            Name = name;
            Manufacturer = manufacturer;
            Type = type;
            Year = year;
        }
        public void InputData()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter manufacturer: ");
            Manufacturer = Console.ReadLine();
            Console.Write("Enter type: ");
            Type = Console.ReadLine();
            Console.Write("Enter year of manufacture: ");
            try
            {
                Year = int.Parse(Console.ReadLine());
                throw new FormatException("You entered the year incorrectly");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Year = 2000;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\tAirplane information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine();
        }
    }
}
