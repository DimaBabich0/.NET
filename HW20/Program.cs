using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW20
{
    internal class Program
    {
        internal class CreditCard
        {
            public event Action<int, int>? OnDeposit;
            public event Action<int, int>? OnWithdraw;
            public event Action<int, int, int>? OnCreditStart;
            public event Action<int, int, int>? OnCreditUsing;
            public event Action<int>? OnCreditLimit;
            public event Action? OnPinChange;

            private void EventOnDeposit(int amount, int sum)
            {
                Console.WriteLine($"Deposited {amount}. New balance: {sum}");
            }
            private void EventOnWithdraw(int amount, int sum)
            {
                Console.WriteLine($"Withdraw {amount}. New balance: {sum}");
            }
            private void EventOnCreditStart(int amount, int UsingCredit, int CreditLimit)
            {
                Console.WriteLine($"Withdrew {amount}. Start using credit balance: {UsingCredit}. Credit limit: {CreditLimit}");
            }
            private void EventOnCreditUsing(int amount, int UsingCredit, int CreditLimit)
            {
                Console.WriteLine($"Withdrew {amount}. Credit balance: {UsingCredit}. Credit limit: {CreditLimit}");
            }
            private void EventOnCreditLimit(int UsingCredit)
            {
                Console.WriteLine($"Unable to withdraw money. You have reached the credit limit: {UsingCredit}");
            }
            private void EventOnPinChange()
            {
                Console.WriteLine("PIN successfully changed");
            }

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


                OnDeposit += EventOnDeposit;
                OnWithdraw += EventOnWithdraw;
                OnCreditStart += EventOnCreditStart;
                OnCreditUsing += EventOnCreditUsing;
                OnCreditLimit += EventOnCreditLimit;
                OnPinChange += EventOnPinChange;
            }

            public void Deposit(int amount)
            {
                if (UsingCredit == 0)
                {
                    Sum += amount;
                    OnDeposit?.Invoke(amount, Sum);
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
                        OnDeposit?.Invoke(amount, Sum);
                    }
                }
            }

            public void Withdraw(int amount)
            {
                if (Sum >= amount)
                {
                    Sum -= amount;
                    OnWithdraw?.Invoke(amount, Sum);
                }
                else
                {
                    if (Sum != 0)
                    {
                        UsingCredit += amount - Sum;
                        Sum = 0;
                        OnCreditStart?.Invoke(amount, UsingCredit, CreditLimit);
                    }
                    else if (Sum == 0 && (UsingCredit + amount) < CreditLimit)
                    {
                        UsingCredit += amount;
                        OnCreditUsing?.Invoke(amount, UsingCredit, CreditLimit);
                    }
                    else
                    {
                        OnCreditLimit?.Invoke(UsingCredit);
                    }
                }
            }

            public void ChangePin(int newPin)
            {
                if (newPin.ToString().Length == 4)
                {
                    PIN = newPin;
                    OnPinChange?.Invoke();
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

        static void Main()
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
}
