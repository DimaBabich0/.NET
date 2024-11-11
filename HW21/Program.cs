using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21
{
    internal class Program
    {
        static void Task1()
        {
            Oceanarium<SeaAnimal> oceanarium = new Oceanarium<SeaAnimal>(3);
            oceanarium.Add(new Dolphin("Orca"));
            oceanarium.Add(new Seal("Walrus"));
            oceanarium.Add(new Starfish("Asterias rubens"));
            oceanarium.Print();
            Console.WriteLine();
        }

        static void Task2()
        {
            FootballTeam<FootballPlayer> team = new FootballTeam<FootballPlayer>("Team", 3);
            team.Add(new FootballPlayer("Connie", "Brady", 25));
            team.Add(new FootballPlayer("Carole", "Dodson", 20));
            team.Add(new FootballPlayer("Galen", "Pham", 23));
            team.Print();
            Console.WriteLine();
        }

        static void Task3()
        {
            Cafe<Worker> cafe = new Cafe<Worker>("Cafe", 3);
            cafe.Add(new Worker("Devon", "Thompson", 23));
            cafe.Add(new Worker("Lauren", "Shelton", 22));
            cafe.Add(new Worker("Rod", "Barr", 25));
            cafe.Print();
            Console.WriteLine();
        }

        static void Main()
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
