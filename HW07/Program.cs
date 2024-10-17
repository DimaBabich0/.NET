using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW07.Employee;
using static HW07.Airplane;

namespace HW07
{
    internal class Program
    {
        static void Main()
        {
            string[] duties = { "Programming", "Code review", "Bug tracking" };
            Employee emp1 = new Employee(
                "Dima Babich",
                19,
                new DateTime(2005, 2, 26),
                "Programmer",
                "0660023431",
                "email@gmail.com",
                duties
            );
            emp1.DisplayInfo();
            Console.WriteLine();

            Employee emp2 = new Employee();
            emp2.InputData();
            emp2.DisplayInfo();
            Console.WriteLine();

            Airplane airplane1 = new Airplane
            (
                "Boeing 747",
                "Boeing Commercial Airplanes",
                "Airliner",
                1970
            );
            airplane1.DisplayInfo();
            Console.WriteLine();

            Airplane airplane2 = new Airplane();
            airplane2.InputData();
            airplane2.DisplayInfo();
        }
    }
}
