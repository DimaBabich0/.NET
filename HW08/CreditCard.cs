using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08
{
    internal class CreditCard
    {
        private string Number { get; set; }
        private string Name { get; set; }
        private int CVC { get; set; }
        private DateTime DateExpiry { get; set; }

        public CreditCard(string number, string name, int cvc, DateTime dateExpiry)
        {
            try
            {
                if (number.Length != 16 || !long.TryParse(number, out _))
                    throw new Exception("You're card number doesn't correspond to the rules");
                else Number = number;

                if (string.IsNullOrWhiteSpace(name))
                    throw new Exception("You entered the empty value for the name");
                else Name = name;

                if (cvc.ToString().Length != 3) 
                    throw new Exception("You entered the wrong value for the CVC"); 
                else CVC = cvc;
                
                if (DateTime.Compare(dateExpiry, DateTime.Now) < 0 || DateTime.Compare(dateExpiry, DateTime.Now) == 0)
                    throw new Exception("You entered the wrong value for the date");
                else DateExpiry = dateExpiry;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}\nCreate new card");
                Number = "00001111222233334444";
                Name = "Name";
                CVC = 123;
                DateExpiry = DateTime.Now.AddYears(1).AddMonths(3);
            }
        }

        public void ShowData()
        {
            Console.WriteLine($"Number: {Number}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"CVC: {CVC}");
            Console.WriteLine($"Date expiry (month/year): {DateExpiry.Month}/{DateExpiry.Year}");
        }
    }
}
