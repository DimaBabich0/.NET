using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW27
{
    internal class Company
    {
        public string Title { get; set; }
        public DateTime DateFounded { get; set; }
        public string Profile { get; set; }
        public string Address { get; set; }
        public string DirectorName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Company(string title, DateTime dateFounded, string profile, string address, string directorName, List<Employee> employees)
        {
            Title = title;
            DateFounded = dateFounded;
            Profile = profile;
            Address = address;
            DirectorName = directorName;
            Employees = employees ?? new List<Employee>();
        }

        public override string ToString()
        {
            return $"\tCompany \"{Title}\"\n" +
                $"Founded: {DateFounded.ToString("dd.MM.yyyy")};\n" +
                $"Profile: {Profile};\n" +
                $"Address: {Address};\n" +
                $"Director: {DirectorName};\n" +
                $"Employees count: {Employees.Count}";
        }
    }
}
