using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    struct Complex
    {
        public double Real { get; }
        public double Imaginary { get; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public Complex Add(Complex obj)
        {
            return new Complex(Real + obj.Real, Imaginary + obj.Imaginary);
        }

        public Complex Sub(Complex obj)
        {
            return new Complex(Real - obj.Real, Imaginary - obj.Imaginary);
        }

        public Complex Mult(Complex obj)
        {
            double real = (Real * obj.Real) - (Imaginary * obj.Imaginary);
            double imaginary = (Real * obj.Imaginary) + (Imaginary * obj.Real);
            return new Complex(real, imaginary);
        }

        public Complex Divide(Complex obj)
        {
            double denominator = obj.Real * obj.Real + obj.Imaginary * obj.Imaginary;
            double real = (Real * obj.Real + Imaginary * obj.Imaginary) / denominator;
            double imaginary = (Imaginary * obj.Real - Real * obj.Imaginary) / denominator;
            return new Complex(real, imaginary);
        }

        public override string ToString()
        {
            if (Real != 0 && Imaginary != 0)
                return $"({Real}{(Imaginary >= 0 ? "+" : "-")}{Math.Abs(Imaginary)}i)";
            else if (Real == 0 && Imaginary != 0)
                return $"({(Imaginary >= 0 ? "" : "-")}{Math.Abs(Imaginary)}i)";
            else if (Real != 0 && Imaginary == 0)
                return $"{Real}";
            else
                return $"0";
        }
    }

    internal class Program
    {
        static void Main()
        {
            Complex c1 = new Complex(2, 5);
            Complex c2 = new Complex(1, -3);

            Complex sum1 = c1.Add(c2);
            Console.WriteLine($"{c1} + {c2} = {sum1}");

            Complex sub1 = c1.Sub(c2);
            Console.WriteLine($"{c1} - {c2} = {sub1}");

            Complex mult1 = c1.Mult(c2);
            Console.WriteLine($"{c1} * {c2} = {mult1}");

            Complex div1 = c1.Divide(c2);
            Console.WriteLine($"{c1} / {c2} = {div1}");
            Console.WriteLine();


            Complex c3 = new Complex(5, 0);
            Complex c4 = new Complex(0, -5);

            Complex sum2 = c3.Add(c4);
            Console.WriteLine($"{c3} + {c4} = {sum2}");

            Complex sub2 = c3.Sub(c4);
            Console.WriteLine($"{c3} - {c4} = {sub2}");

            Complex mult2 = c3.Mult(c4);
            Console.WriteLine($"{c3} * {c4} = {mult2}");

            Complex div2 = c3.Divide(c4);
            Console.WriteLine($"{c3} / {c4} = {div2}");
        }
    }
}
