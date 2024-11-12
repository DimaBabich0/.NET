using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW23
{
    internal class Program
    {
        static void Task1()
        {
            string[] examples = {
                "(+380) 98 499 40 84",
                "380984994084",
                "0984994084",
                "098-499-40-84"
            };

            string[] patterns = {
                @"^\(\+380\)\s\d{2}\s\d{3}\s\d{2}\s\d{2}$",
                @"^?380\d{9}$",
                @"^0\d{9}$",
                @"^0\d{2}-\d{3}-\d{2}-\d{2}$"
            };
            Regex[] regexs = new Regex[patterns.Length];
            for (int i = 0; i < patterns.Length; i++)
            {
                regexs[i] = new Regex(patterns[i]);
            }
            int indexPattern = -1;

            for (int i = 0; i < examples.Length; i++)
            {

                for (int j = 0; j < regexs.Length; j++)
                {
                    if (regexs[j].IsMatch(examples[i]))
                    {
                        indexPattern = j;
                        break;
                    }
                }
                if (indexPattern != -1)
                {
                    Console.WriteLine("Example \"{0}\" is match with pattern #{1}: {2}", examples[i], indexPattern, patterns[indexPattern]);
                }
                else
                {
                    Console.WriteLine("Example \"{0}\" is not match with patterns", examples[i]);
                }
            }
            Console.WriteLine("--------------------------------------");

            Console.Write("Enter your phone number: ");
            string userPhone = Console.ReadLine();
            indexPattern = -1;
            for (int i = 0; i < patterns.Length; i++)
            {
                if (regexs[i].IsMatch(userPhone))
                {
                    indexPattern = i;
                    break;
                }
            }
            if (indexPattern != -1)
            {
                Console.WriteLine("You're phone number \"{0}\" is match with pattern #{1}: {2}", userPhone, indexPattern, patterns[indexPattern]);
            }
            else
            {
                Console.WriteLine("You're phone number \"{0}\" is not match with patterns", userPhone);
            }
            Console.WriteLine();
        }

        static void Task2()
        {
            string emailPattern = @"^[a-zA-Z][a-zA-Z0-9]*@gmail\.com$";
            Regex regex = new Regex(emailPattern);
            string[] examples = { "babich123@gmail.com", "123babich@gmail.com", "babich123@ukr.ua" };

            for (int i = 0; i < examples.Length; i++)
            {
                if (regex.IsMatch(examples[i]))
                {
                    Console.WriteLine("Example \"{0}\" is match with pattern", examples[i]);
                }
                else
                {
                    Console.WriteLine("Example \"{0}\" is not match with pattern", examples[i]);
                }
            }
            Console.WriteLine("--------------------------------------");

            Console.Write("Enter your email: ");
            string userEmail = Console.ReadLine();
            if (regex.IsMatch(userEmail))
            {
                Console.WriteLine("You're email \"{0}\" is match with pattern", userEmail);
            }
            else
            {
                Console.WriteLine("You're email \"{0}\" is not match with pattern", userEmail);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Task1();
            Task2();
        }
    }
}
