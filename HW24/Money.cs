using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW24
{
    class Money
    {
        public int Hryvnia { get; private set; }
        public int Kopiyka { get; private set; }

        public Money(int hryvnia, int kopiyka)
        {
            if (hryvnia < 0 || kopiyka < 0)
                throw new Exception("Number can't be negative");

            Hryvnia = hryvnia;
            Kopiyka = kopiyka;
            Normalize();
        }

        private void Normalize()
        {
            Hryvnia += Kopiyka / 100;
            Kopiyka %= 100;
        }

        public static Money operator +(Money a, Money b)
        {
            Money result = new Money(a.Hryvnia + b.Hryvnia, a.Kopiyka + b.Kopiyka);
            return result;
        }

        public static Money operator -(Money a, Money b)
        {
            int totalA = a.Hryvnia * 100 + a.Kopiyka;
            int totalB = b.Hryvnia * 100 + b.Kopiyka;

            if (totalA < totalB)
                throw new Exception("Bankrupt");

            Money result = new Money((totalA - totalB) / 100, (totalA - totalB) % 100);
            return result;
        }

        public static Money operator *(Money a, int mult)
        {
            int total = (a.Hryvnia * 100 + a.Kopiyka) * mult;
            Money result = new Money(total / 100, total % 100);
            return result;
        }

        public static Money operator /(Money a, int divisor)
        {
            if (divisor <= 0)
                throw new Exception("The divider must be greater than zero");

            int total = a.Hryvnia * 100 + a.Kopiyka;
            Money result = new Money(total / divisor / 100, (total / divisor) % 100);
            return result;
        }

        public static Money operator ++(Money a)
        {
            a.Kopiyka++;
            a.Normalize();
            return a;
        }

        public static Money operator --(Money a)
        {
            if (a.Hryvnia == 0 && a.Kopiyka == 1)
            {
                throw new Exception("Bankrupt");
            }

            a.Kopiyka--;
            if (a.Kopiyka < 0)
            {
                a.Hryvnia--;
                a.Kopiyka += 100;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{Hryvnia}.{Kopiyka}";
        }
    }
}
