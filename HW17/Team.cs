using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    internal class Team
    {
        private readonly Worker[] Workers;
        private readonly TeamLeader TeamLeader;
        private readonly House House;

        public Team(Worker[] workers, TeamLeader teamLeader, House house)
        {
            Workers = workers;
            TeamLeader = teamLeader;
            House = house;
        }

        public void BeginConstruction()
        {
            bool isComp = false;

            while (!isComp)
            {
                foreach (var worker in Workers)
                {
                    worker.Work(House);
                }
                TeamLeader.Work(House);
                Console.WriteLine();

                isComp = IsConstructionComplete();
            }

            Console.WriteLine("   ____| |__");
            Console.WriteLine("   /       \\");
            Console.WriteLine("  /         \\");
            Console.WriteLine(" /           \\");
            Console.WriteLine("/_____________\\");
            Console.WriteLine("|             |");
            Console.WriteLine("|  []     []  |");
            Console.WriteLine("|     ___     |");
            Console.WriteLine("|  [] | | []  |");
            Console.WriteLine("|_____|_|_____|");
        }
        private bool IsConstructionComplete()
        {
            bool basementBuilt = House.Basement.IsBuilt;
            bool doorBuilt = House.Door.IsBuilt;
            bool roofBuilt = House.Roof.IsBuilt;
            bool wallsBuilt = Array.TrueForAll(House.Walls, walls => walls.IsBuilt);
            bool windowsBuilt = Array.TrueForAll(House.Windows, windows => windows.IsBuilt);

            return basementBuilt && wallsBuilt && windowsBuilt && doorBuilt && roofBuilt;
        }
    }
}
