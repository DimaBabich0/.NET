using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW22
{
    internal class EmployeeManager
    {
        public Dictionary<string, string> Employees { get; private set; } = new Dictionary<string, string>();
        
        public void AddEmployee(string login, string password)
        {
            if (!Employees.ContainsKey(login))
            {
                Employees[login] = password;
                Console.WriteLine($"Employee \"{login}\" added");
            }
            else
                Console.WriteLine($"Employee \"{login}\" already exists");
        }
        
        public void DeleteEmployee(string login)
        {
            if (Employees.Remove(login))
                Console.WriteLine($"Employee \"{login}\" removed");
            else
                Console.WriteLine($"Employee \"{login}\" not found");
        }

        public void EditEmployee(string login, string newPassword)
        {
            if (Employees.ContainsKey(login))
            {
                Employees[login] = newPassword;
                Console.WriteLine($"Employee \"{login}\" information updated");
            }
            else
                Console.WriteLine($"Employee \"{login}\" not found");
        }
        
        public string GetPassword(string login)
        {
            if (Employees.TryGetValue(login, out string password))
                return password; 
            else return null;
        }
    }
}
