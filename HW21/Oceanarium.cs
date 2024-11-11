using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21
{
    internal class Oceanarium<T> : IEnumerable<T> where T : SeaAnimal
    {
        public T[] SeaAnimals { get; private set; }

        public Oceanarium(int count)
        {
            SeaAnimals = new T[count];
        }

        public void Print()
        {
            Console.WriteLine("\tInfo:");

            foreach (var creature in this)
            {
                if (creature != null)
                {
                    Console.WriteLine($"Name: {creature.Name}; Type: {creature.Type}");
                }
            }
        }

        public void Add(T creature)
        {
            for (int i = 0; i < SeaAnimals.Length; i++)
            {
                if (SeaAnimals[i] == null)
                {
                    SeaAnimals[i] = creature;
                    return;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var creature in SeaAnimals)
            {
                if (creature != null)
                {
                    yield return creature;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public abstract class SeaAnimal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public SeaAnimal()
        {
            Name = string.Empty;
            Type = string.Empty;
        }
    }
    public class Dolphin : SeaAnimal
    {
        public Dolphin(string name)
        {
            Name = name;
            Type = "Dolphin";
        }
    }
    public class Seal : SeaAnimal
    {
        public Seal(string name)
        {
            Name = name;
            Type = "Seal";
        }
    }
    public class Starfish : SeaAnimal
    {
        public Starfish(string name)
        {
            Name = name;
            Type = "Starfish";
        }
    }
}
