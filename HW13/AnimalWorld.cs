using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    sealed class AnimalWorld
    {
        private Continent Continent;
        private List<Herbivore> Herbivores = new List<Herbivore>();
        private List<Carnivore> Carnivores = new List<Carnivore>();

        public AnimalWorld(Continent continent)
        {
            Continent = continent;
            AddHerbivore();
            AddCarnivore();
        }

        public void AddHerbivore()
        {
            Herbivores.Add(Continent.CreateHerbivore());
        }
        public void AddCarnivore()
        {
            Carnivores.Add(Continent.CreateCarnivore());
        }

        public void PrintHerbivores()
        {
            Console.WriteLine("\tList of herbivores:");
            foreach (Herbivore herbivore in Herbivores)
            {
                herbivore.Print();
            }
            Console.WriteLine();
        }

        public void PrintCarnivores()
        {
            Console.WriteLine("\tList of carnivores:");
            foreach (Carnivore carnivore in Carnivores)
            {
                carnivore.Print();
            }
            Console.WriteLine();
        }

        public void MealsHerbivores()
        {
            foreach (Herbivore herbivore in Herbivores)
            {
                herbivore.EatGrass();
            }
        }

        public void NutritionCarnivores()
        {
            for (int i = 0; i < Carnivores.Count; i++)
            {
                bool isAte = false;
                for (int j = 0; j < Herbivores.Count; j++)
                {
                    if (Herbivores[j].Life)
                    {
                        Carnivores[i].Eat(Herbivores[j]);
                        isAte = true;
                        break;
                    }
                }
                if (!isAte) Carnivores[i].Eat(Herbivores[0]);
            }
        }
    }
}
