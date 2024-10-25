using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    abstract class Continent
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    class Africa : Continent
    {
        public override Herbivore CreateHerbivore() => new Wildebeest(50);
        public override Carnivore CreateCarnivore() => new Lion(100);
    }

    class NorthAmerica : Continent
    {
        public override Herbivore CreateHerbivore() => new Bison(70);
        public override Carnivore CreateCarnivore() => new Wolf(80);
    }

    class Australia : Continent
    {
        public override Herbivore CreateHerbivore() => new Kangaroo(40);
        public override Carnivore CreateCarnivore() => new AustralianWolf(90);
    }
}
