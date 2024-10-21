using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    class Magazine
    {
        private int _year;
        private string _phoneNumber;
        private string _email;
        private int _numOfEmployees;

        public string Name { get; set; }
        public string Description { get; set; }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value <= 0) throw new Exception("Year can't be below zero");
                else _year = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value.Length != 13 || string.IsNullOrWhiteSpace(value)) throw new Exception("Wrong phone number (example \"+380ХХХХХХХХХ\")");
                else _phoneNumber = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (!value.Contains("@gmail.com") || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Wrong input of mail (must be \"@gmail.com\")");
                }
                else _email = value;
            }
        }
        public int NumberOfEmployees
        {
            get
            {
                return _numOfEmployees;
            }
            set
            {
                if (value < 0) throw new Exception("Number of employees can't be below zero");
                else _numOfEmployees = value;
            }
        }

        public Magazine()
        {
            Name = "By default";
            Description = "By default";
            Year = DateTime.Now.Year;
            PhoneNumber = "+380ХХХХХХХХХ";
            Email = "example@gmail.com";
            NumberOfEmployees = 1;
        }

        public Magazine(string name, string description, int year, string phoneNumber, string email, int numOfEmployees)
        {
            Name = name;
            Description = description;

            try
            {
                Year = year;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Year = Convert.ToInt32(DateTime.Now.Year);
            }

            try
            {
                PhoneNumber = phoneNumber;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                PhoneNumber = "+380ХХХХХХХХХ";
            }

            try
            {
                Email = email;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Email = "example@gmail.com";
            }

            try
            {
                NumberOfEmployees = numOfEmployees;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                NumberOfEmployees = 1;
            }
        }   

        public void ShowInfo()
        {
            Console.WriteLine("\tMagazine info:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Phone number: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Number of employees: {NumberOfEmployees}");
        }

        public static Magazine operator +(Magazine obj1, Magazine obj2)
        {
            Magazine obj3 = obj1;
            obj3.NumberOfEmployees += obj2.NumberOfEmployees;
            return obj3;
        }
        public static Magazine operator -(Magazine obj1, Magazine obj2)
        {
            Magazine obj3 = new Magazine();
            if (obj1.NumberOfEmployees > obj2.NumberOfEmployees)
            {
                obj3 = obj1;
                obj3.NumberOfEmployees -= obj2.NumberOfEmployees;
            }
            else if (obj1.NumberOfEmployees < obj2.NumberOfEmployees)
            {
                obj3 = obj2;
                obj3.NumberOfEmployees -= obj1.NumberOfEmployees;
            }
            return obj3;
        }

        public static bool operator ==(Magazine obj1, Magazine obj2)
        {
            if (obj1.NumberOfEmployees == obj2.NumberOfEmployees) return true;
            else return false;
        }
        public static bool operator !=(Magazine obj1, Magazine obj2)
        {
            if (obj1.NumberOfEmployees != obj2.NumberOfEmployees) return true;
            else return false;
        }

        public static bool operator >(Magazine obj1, Magazine obj2)
        {
            if (obj1.NumberOfEmployees > obj2.NumberOfEmployees) return true;
            else return false;
        }
        public static bool operator <(Magazine obj1, Magazine obj2)
        {
            if (obj1.NumberOfEmployees < obj2.NumberOfEmployees) return true;
            else return false;
        }
    }

    class Store
    {
        private string _phoneNumber;
        private string _email;
        private int _num_of_area;

        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int NumberOfArea
        {
            get
            {
                return _num_of_area;
            }
            set
            {
                if (value < 0) throw new Exception("Number of area can't be below zero");
                else _num_of_area = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value.Length != 13 || string.IsNullOrWhiteSpace(value)) throw new Exception("Wrong phone number (example \"+380ХХХХХХХХХ\")");
                else _phoneNumber = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (!value.Contains("@gmail.com") || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Wrong input of mail (must be \"@gmail.com\")");
                }
                else _email = value;
            }
        }

        public Store()
        {
            Name = "By default";
            Address = "By default";
            Description = "By default";
            PhoneNumber = "+380ХХХХХХХХХ";
            Email = "example@gmail.com";
            NumberOfArea = 1;
        }

        public Store(string name, string address, string description, string phoneNumber, string email, int numOfArea)
        {
            Name = name;
            Address = address;
            Description = description;

            try
            {
                PhoneNumber = phoneNumber;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                PhoneNumber = "+380ХХХХХХХХХ";
            }

            try
            {
                Email = email;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Email = "example@gmail.com";
            }

            try
            {
                NumberOfArea = numOfArea;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                NumberOfArea = 1;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("\tStore info:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Phone number: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Number of area: {NumberOfArea}");
        }

        public static Store operator +(Store obj1, Store obj2)
        {
            Store obj3 = obj1;
            obj3.NumberOfArea += obj2.NumberOfArea;
            return obj3;
        }
        public static Store operator -(Store obj1, Store obj2)
        {
            Store obj3 = new Store();
            if(obj1.NumberOfArea > obj2.NumberOfArea)
            {
                obj3 = obj1;
                obj3.NumberOfArea -= obj2.NumberOfArea;
            }
            else if (obj1.NumberOfArea < obj2.NumberOfArea)
            {
                obj3 = obj2;
                obj3.NumberOfArea -= obj1.NumberOfArea;
            }
            return obj3;
        }

        public static bool operator ==(Store obj1, Store obj2)
        {
            if (obj1.NumberOfArea == obj2.NumberOfArea) return true;
            else return false;
        }
        public static bool operator !=(Store obj1, Store obj2)
        {
            if (obj1.NumberOfArea != obj2.NumberOfArea) return true;
            else return false;
        }

        public static bool operator >(Store obj1, Store obj2)
        {
            if (obj1.NumberOfArea > obj2.NumberOfArea) return true;
            else return false;
        }
        public static bool operator <(Store obj1, Store obj2)
        {
            if (obj1.NumberOfArea < obj2.NumberOfArea) return true;
            else return false;
        }
    }

    internal class Program
    {
        static void Task1()
        {
            Magazine mg1 = new Magazine();
            mg1.ShowInfo();
            Console.WriteLine();

            try
            {
                mg1.Name = "Magazine #1";
                mg1.Description = "Some description";
                mg1.Year = 2023;
                mg1.PhoneNumber = "+380660023270";
                mg1.Email = "magazine1@gmail.com";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            mg1.ShowInfo();
            Console.WriteLine();

            Magazine mg2 = new Magazine("Magazine #2", "Another description", 2024, "+380636090807", "magazine2@gmail.com", 15);
            mg2.ShowInfo();
            Console.WriteLine();

            Magazine mg3 = new Magazine("Magazine #3", "Third description", 0, "", "email@notGmail.com", -20);
            mg3.ShowInfo();
            Console.WriteLine();

            Console.WriteLine($"Is mg2 == mg2?\nAnswer: {mg2 == mg2}\n");
            Console.WriteLine($"Is mg2 == mg3?\nAnswer: {mg2 == mg3}\n");
            Console.WriteLine($"Is mg2 != mg3?\nAnswer: {mg2 != mg3}\n");
            Console.WriteLine($"Is mg2 > mg3?\nAnswer: {mg2 > mg3}\n");

            Console.Write($"mg2 ({mg2.NumberOfEmployees}) + mg3 ({mg3.NumberOfEmployees}) = ");
            Magazine magazine = mg2 + mg3;
            Console.WriteLine($"new magazine ({magazine.NumberOfEmployees})");
        }

        static void Task2()
        {
            Store st1 = new Store();
            st1.ShowInfo();
            Console.WriteLine();

            try
            {
                st1.Name = "Store #1";
                st1.Description = "Some description";
                st1.Address = "Address#1";
                st1.PhoneNumber = "+380660023270";
                st1.Email = "store1@gmail.com";
                st1.NumberOfArea = 50;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            st1.ShowInfo();
            Console.WriteLine();

            Store st2 = new Store("Store #2", "Address#2", "Another description", "+380636090807", "store2@gmail.com", 100);
            st2.ShowInfo();
            Console.WriteLine();

            Store st3 = new Store("Store #3", "Address#3", "Third description", "", "email@notGmail.com", -20);
            st3.ShowInfo();
            Console.WriteLine();

            Console.WriteLine($"Is st2 == st2?\nAnswer: {st2 == st2}\n");
            Console.WriteLine($"Is st2 == st3?\nAnswer: {st2 == st3}\n");
            Console.WriteLine($"Is st2 != st3?\nAnswer: {st2 != st3}\n");
            Console.WriteLine($"Is st2 > st3?\nAnswer: {st2 > st3}\n");

            Console.Write($"st1 ({st1.NumberOfArea}) + st2 ({st2.NumberOfArea}) = ");
            Store store = st1 + st2;
            Console.WriteLine($"new store ({store.NumberOfArea})");
        }

        static void Main()
        {
            // Задание с журналом
            Task1();

            // Задание с магазином
            Task2();
        }
    }
}
