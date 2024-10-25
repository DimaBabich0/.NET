using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    abstract class Carnivore
    {
        public int Power { get; set; }

        public abstract void Eat(Herbivore herbivore);
        public void Print()
        {
            Console.WriteLine($"Name: {this.GetType().Name}; Power: {Power};");
        }
    }

    class Lion : Carnivore
    {
        public Lion(int power) => Power = power;

        public override void Eat(Herbivore herbivore)
        {
            int temp = Power;
            if (Power > herbivore.Weight && herbivore.Life)
            {
                Power += 10;
                Console.WriteLine($"Lion ate {herbivore.GetType().Name}. The \"power\" value has been increased from {temp} to {Power}");
                herbivore.Life = false;
            }
            else if (Power <= herbivore.Weight && herbivore.Life)
            {
                Power -= 10;
                Console.WriteLine($"Lion couldn't ate {herbivore.GetType().Name}. The \"power\" value has been reduced from {temp} to {Power}");
            }
            else
            {
                Power -= 10;
                Console.WriteLine($"Lion couldn't ate {herbivore.GetType().Name}. The \"power\" value has been reduced from {temp} to {Power}");
            }
        }
    }

    class Wolf : Carnivore
    {
        public Wolf(int power) => Power = power;

        public override void Eat(Herbivore herbivore)
        {
            int temp = Power;
            if (Power > herbivore.Weight && herbivore.Life)
            {
                Power += 10;
                Console.WriteLine($"Wolf ate {herbivore.GetType().Name}. The \"power\" value has been increased from {temp} to {Power}");
                herbivore.Life = false;
            }
            else if (Power <= herbivore.Weight && herbivore.Life)
            {
                Power -= 10;
                Console.WriteLine($"Wolf couldn't ate {herbivore.GetType().Name}. The \"power\" value has been reduced from {temp} to {Power}");
            }
            else
            {
                Power -= 10;
                Console.WriteLine($"Lion couldn't ate {herbivore.GetType().Name}. The \"power\" value has been reduced from {temp} to {Power}");
            }
        }
    }

    class AustralianWolf : Carnivore
    {
        public AustralianWolf(int power) => Power = power;

        public override void Eat(Herbivore herbivore)
        {
            int temp = Power;
            if (Power > herbivore.Weight && herbivore.Life)
            {
                Power += 10;
                Console.WriteLine($"Australian wolf ate {herbivore.GetType().Name}. The \"power\" value has been increased from {temp} to {Power}");
                herbivore.Life = false;
            }
            else if (Power <= herbivore.Weight && herbivore.Life)
            {
                Power -= 10;
                Console.WriteLine($"Australian wolf couldn't ate {herbivore.GetType().Name}. The \"power\" value has been reduced from {temp} to {Power}");
            }
            else
            {
                Power -= 10;
                Console.WriteLine($"Lion couldn't ate {herbivore.GetType().Name}. The \"power\" value has been reduced from {temp} to {Power}");
            }
        }
    }
}
