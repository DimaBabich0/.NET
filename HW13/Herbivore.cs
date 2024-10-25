using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    abstract class Herbivore
    {
        public int Weight { get; set; }
        public bool Life { get; set; } = true;

        public abstract void EatGrass();
        public void Print()
        {
            Console.WriteLine($"Name: {this.GetType().Name}; Weight: {Weight}; Status: {(Life == true ? "alive" : "dead")};");
        }
    }

    class Wildebeest : Herbivore
    {
        public Wildebeest(int weight) => Weight = weight;

        public override void EatGrass()
        {
            if (!Life) { return; }

            int temp = Weight;
            Weight += 10;
            Console.WriteLine($"Wildebeest eats grass. The \"weight\" value has been increased from {temp} to {Weight}");
        }
    }

    class Bison : Herbivore
    {
        public Bison(int weight) => Weight = weight;

        public override void EatGrass()
        {
            if (!Life) { return; }

            int temp = Weight;
            Weight += 10;
            Console.WriteLine($"Bison eats grass. The \"weight\" value has been increased from {temp} to {Weight}");
        }
    }

    class Kangaroo : Herbivore
    {
        public Kangaroo(int weight) => Weight = weight;

        public override void EatGrass()
        {
            if (!Life) { return; }

            int temp = Weight;
            Weight += 10;
            Console.WriteLine($"Kangaroo eats grass. The \"weight\" value has been increased from {temp} to {Weight}");
        }
    }
}
