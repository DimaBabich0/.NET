using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    internal class Program
    {
        static void WaitContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Main()
        {
            //Africa
            AnimalWorld africaWorld = new AnimalWorld(new Africa());
            africaWorld.PrintHerbivores();
            africaWorld.PrintCarnivores();
            Console.WriteLine();

            africaWorld.MealsHerbivores();
            africaWorld.NutritionCarnivores();
            Console.WriteLine();

            africaWorld.PrintHerbivores();
            africaWorld.PrintCarnivores();
            Console.WriteLine();
            WaitContinue();
            Console.Clear();

            //North America
            AnimalWorld northAmericaWorld = new AnimalWorld(new NorthAmerica());
            northAmericaWorld.PrintHerbivores();
            northAmericaWorld.PrintCarnivores();
            Console.WriteLine();

            northAmericaWorld.MealsHerbivores();
            northAmericaWorld.NutritionCarnivores();
            Console.WriteLine();

            northAmericaWorld.PrintHerbivores();
            northAmericaWorld.PrintCarnivores();
            Console.WriteLine();
            WaitContinue();
            Console.Clear();

            //Australia
            AnimalWorld australiaWorld = new AnimalWorld(new Australia());
            australiaWorld.PrintHerbivores();
            australiaWorld.PrintCarnivores();
            Console.WriteLine();

            australiaWorld.MealsHerbivores();
            australiaWorld.NutritionCarnivores();
            Console.WriteLine();

            australiaWorld.PrintHerbivores();
            australiaWorld.PrintCarnivores();
            Console.WriteLine();
        }
    }
}
