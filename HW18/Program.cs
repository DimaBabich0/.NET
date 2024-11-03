using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static HW18.Task3;

namespace HW18
{
    internal class Task1
    {
        delegate void DTask1(int[] arr);

        private static bool IsEven(int number) => number % 2 == 0;
        private static bool IsOdd(int number) => number % 2 != 0;

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private static bool IsPerfectSquare(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }
        private static bool IsFibonacci(int number)
        {
            if (number < 0) return false;
            int x = 5 * number * number;
            return IsPerfectSquare(x + 4) || IsPerfectSquare(x - 4);
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        private static int[] GetFilterArray(int[] array, Func<int, bool> condition)
        {
            return array.Where(condition).ToArray();
        }
        private static void PrintFilteredArray(int[] array, Func<int, bool> condition, string label)
        {
            int[] filteredArray = GetFilterArray(array, condition);
            Console.Write($"{label}: ");
            PrintArray(filteredArray);
        }

        public void Run()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            DTask1 del = array =>
            {
                PrintFilteredArray(array, IsEven, "Even numbers");
                PrintFilteredArray(array, IsOdd, "Odd numbers");
                PrintFilteredArray(array, IsPrime, "Prime numbers");
                PrintFilteredArray(array, IsFibonacci, "Fibonacci numbers");
            };

            del(arr);
            Console.WriteLine();
        }
    }

    internal class Task2
    {
        static void ShowCurrentTime()
        {
            Console.WriteLine("Current Time: " + DateTime.Now.ToString("HH:mm:ss"));
        }

        static void ShowCurrentDate()
        {
            Console.WriteLine("Current Date: " + DateTime.Now.ToString("dd/MM/yyyy"));
        }

        static void ShowCurrentDayOfWeek()
        {
            Console.WriteLine("Current day of the week: " + DateTime.Now.DayOfWeek);
        }

        static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }

        public void Run()
        {
            Action showTime = ShowCurrentTime;
            Action showDate = ShowCurrentDate;
            Action showDayOfWeek = ShowCurrentDayOfWeek;

            showTime();
            showDate();
            showDayOfWeek();

            Func<double, double, double> triangleArea = CalculateTriangleArea;
            Func<double, double, double> rectangleArea = CalculateRectangleArea;

            double baseLength = 5;
            double triangleHeight = 10;
            double rectangleWidth = 8;
            double rectangleHeight = 12;

            Console.WriteLine("Triangle Area: " + triangleArea(baseLength, triangleHeight));
            Console.WriteLine("Rectangle Area: " + rectangleArea(rectangleWidth, rectangleHeight));
        }
    }

    internal class Task3
    {
        public delegate void AccountStateHandler(string message);

        internal class CreditCard
        {
            AccountStateHandler OnDeposit;
            AccountStateHandler OnWithdraw;
            AccountStateHandler OnCreditUse;
            AccountStateHandler OnPinChange;

            private string Number { get; set; }
            private string Name { get; set; }
            private DateTime DateExpiry { get; set; }
            private int PIN { get; set; }
            private int Sum { get; set; }
            private int CreditLimit { get; set; }
            private int UsingCredit { get; set; } = 0;

            public CreditCard(string number, string name, int pin, DateTime dateExpiry, int sum, int creditLimit)
            {
                try
                {
                    if (number.Length != 16 || !long.TryParse(number, out _))
                        throw new Exception("You're card number doesn't correspond to the rules");
                    else Number = number;

                    if (string.IsNullOrWhiteSpace(name))
                        throw new Exception("You entered the empty value for the name");
                    else Name = name;

                    if (pin.ToString().Length != 4)
                        throw new Exception("You entered the wrong value for the PIN");
                    else PIN = pin;

                    if (DateTime.Compare(dateExpiry, DateTime.Now) < 0 || DateTime.Compare(dateExpiry, DateTime.Now) == 0)
                        throw new Exception("You entered the wrong value for the date");
                    else DateExpiry = dateExpiry;

                    if (sum < 0)
                        throw new Exception("You entered the wrong value for the sum");
                    else Sum = sum;

                    if (creditLimit < 0)
                        throw new Exception("You entered the wrong value for the credit limit");
                    else CreditLimit = creditLimit;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\nCreate new card");
                    Number = "00001111222233334444";
                    Name = "Name";
                    PIN = 123;
                    DateExpiry = DateTime.Now.AddYears(1).AddMonths(3);
                    Sum = 0;
                    CreditLimit = 1000;
                }

                OnDeposit += message => Console.WriteLine(message);
                OnWithdraw += message => Console.WriteLine(message);
                OnCreditUse += message => Console.WriteLine(message);
                OnPinChange += message => Console.WriteLine(message);
            }


            public void Deposit(int amount)
            {
                if (UsingCredit == 0)
                {
                    Sum += amount;
                    OnDeposit?.Invoke($"Deposited {amount}. New balance: {Sum}");
                }
                else
                {
                    if (UsingCredit > amount)
                    {
                        UsingCredit -= amount;
                        Console.WriteLine($"Part of the credit is paid. To be paid: {UsingCredit}");
                    }
                    else
                    {
                        int left = amount - UsingCredit;
                        UsingCredit = 0;
                        Sum += left;
                        Console.WriteLine($"Сredit paid off");
                        OnDeposit?.Invoke($"Deposited {amount}. New balance: {Sum}");
                    }
                }
            }

            public void Withdraw(int amount)
            {
                if (Sum >= amount)
                {
                    Sum -= amount;
                    OnWithdraw?.Invoke($"Withdraw {amount}. New balance: {Sum}");
                }
                else
                {
                    if (Sum != 0)
                    {
                        UsingCredit += amount - Sum;
                        Sum = 0;
                        OnCreditUse?.Invoke($"Withdrew {amount}. Start using credit balance: {UsingCredit}. Credit limit: {CreditLimit}");
                    }
                    else if (Sum == 0 && (UsingCredit + amount) < CreditLimit)
                    {
                        UsingCredit += amount;
                        OnCreditUse?.Invoke($"Withdrew {amount}. Credit balance: {UsingCredit}. Credit limit: {CreditLimit}");
                    }
                    else
                    {
                        OnCreditUse?.Invoke($"Unable to withdraw money. You have reached the credit limit: {UsingCredit}");
                    }
                }
            }

            public void ChangePin(int newPin)
            {
                if (newPin.ToString().Length == 4)
                {
                    PIN = newPin;
                    OnPinChange?.Invoke("PIN successfully changed");
                }
                else
                {
                    Console.WriteLine("New PIN must be 4 digits");
                }
            }

            public void ShowData()
            {
                Console.WriteLine($"Number: {Number}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"PIN: {PIN}");
                Console.WriteLine($"Date expiry (month/year): {DateExpiry.Month}/{DateExpiry.Year}");
                Console.WriteLine($"Current Balance: {Sum}");
                Console.WriteLine($"Credit Limit: {CreditLimit}");
                if (UsingCredit > 0)
                    Console.WriteLine($"Credit: {UsingCredit}");
            }
        }
        public void Run()
        {
            CreditCard card = new CreditCard("1111222233334444", "Dima Babich", 1234, new DateTime(2025, 11, 11), 500, 1000);

            Console.WriteLine("Data of new card:");
            card.ShowData();
            Console.WriteLine();

            Console.WriteLine("Add 200 to card:");
            card.Deposit(200);
            Console.WriteLine();

            Console.WriteLine("Withdraw 500 from card:");
            card.Withdraw(500);
            Console.WriteLine();

            Console.WriteLine("Withdraw extra 500 from card with using credit:");
            card.Withdraw(500);
            card.ShowData();
            Console.WriteLine();

            Console.WriteLine("Add 800 to card to pay back credit:");
            card.Deposit(800);
            card.ShowData();
            Console.WriteLine();

            Console.WriteLine("Change PIN to \"5678\":");
            card.ChangePin(5678);
            card.ShowData();
            Console.WriteLine();
        }
    }


    internal class Program
    {
        static void Main()
        {
            Task1 task1 = new Task1();
            task1.Run();

            Task2 task2 = new Task2();
            task2.Run();

            Task3 task3 = new Task3();
            task3.Run();
        }
    }
}
