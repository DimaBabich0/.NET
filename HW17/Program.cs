using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    internal class Program
    {
        static void Main()
        {
            House house = new House();

            Worker[] workers = {
                new Worker("Dale", "Adams"),
                new Worker("Barbara", "Bender"),
                new Worker("Jake", "Barton"),
                new Worker("Jeremiah", "Ward")
            };
            TeamLeader teamLeader = new TeamLeader("Dima", "Babich");
            Team team = new Team(workers, teamLeader, house);

            team.BeginConstruction();
        }
    }
}
