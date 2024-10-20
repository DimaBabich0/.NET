using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09
{
    internal class MyDate
    {
        private int day;
        private int month;
        private int year;

        private bool isValid(string date)
        {
            DateTime d;
            bool isValid = DateTime.TryParseExact(
            date,
            "dd.MM.yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out d);
            return isValid;
        }

        public MyDate()
        {
            DateTime date = DateTime.Now;
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
        }
        public MyDate(int day, int month, int year)
        {
            DateTime d;

            string date = $"{day:00}.{month:00}.{year}";
            bool isValid = DateTime.TryParseExact(
            date,
            "dd.MM.yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out d);

            if (isValid == true)
            {
                d = new DateTime(year, month, day);
            }
            else
            {
                Console.WriteLine("Date not valid. Variable was initialized to current time");
                d = DateTime.Now;
            }

            Year = d.Year;
            Month = d.Month;
            Day = d.Day;
        }

        public void ShowDate()
        {
            Console.WriteLine($"{Day:00}.{Month:00}.{Year}");
        }
        public string ReturnDate()
        {
            return $"{Day:00}.{Month:00}.{Year}";
        }

        public void ShowDifference(MyDate date)
        {
            DateTime Date1 = new DateTime(Year, Month, Day);
            DateTime Date2 = new DateTime(date.Year, date.Month, date.Day);

            TimeSpan t;
            if (DateTime.Compare(Date1, Date2) > 0)
            {
                t = Date1 - Date2;
            }
            else if (DateTime.Compare(Date1, Date2) < 0)
            {
                t = Date2 - Date1;
            }
            else
            {
                Console.WriteLine("Dates are the same");
                return;
            }
            Console.WriteLine($"Difference between dates {this.ReturnDate()} and {date.ReturnDate()} is: {t.Days} days");
        }

        public void ChangeForwardDays(int days)
        {
            DateTime date = new DateTime(Year, Month, Day);
            date = date.AddDays(days);

            try
            {
                Year = date.Year;
                Month = date.Month;
                Day = date.Day;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return;
            }
            Console.WriteLine($"Date changed {days} days in forward");
        }
        public void ChangeBackDays(int days)
        {
            DateTime date = new DateTime(Year, Month, Day);
            date = date.AddDays(-days);

            Year = date.Year;
            Month = date.Month;
            Day = date.Day;

            Console.WriteLine($"Date changed {days} days in backwards");
        }

        public int Day
        {
            get { return day; }
            set
            {
                try
                {
                    if (isValid($"{value:00}.{Month:00}.{Year}") == true) day = value;
                    else throw new Exception("Day not valid");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                try
                {
                    if (value >= 1 && value <= 12) month = value;
                    else throw new Exception("Month should be in the range of 1 to 12");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                try
                {
                    if (value >= 0) year = value;
                    else throw new Exception("Year cannot be less than 0");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        public string Day_Of_Week
        {
            get
            {
                DateTime date = new DateTime(Year, Month, Day);
                return Convert.ToString(date.DayOfWeek);
            }
        }
    }

}
