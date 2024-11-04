using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    internal interface IWorker
    {
        string FirstName { get; }
        string LastName { get; }
        void Work(House house);
    }

    internal class Worker : IWorker
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Worker(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void ReportBuilt(IPart part)
        {
            Console.WriteLine($"Builder {FirstName} {LastName} built a {part.PartName}.");
        }

        public bool CheckAndBuildPart(House house, IPart part)
        {
            if (!part.IsBuilt)
            {
                part.IsBuilt = true;
                ReportBuilt(part);
                return true;
            }
            return false;
        }

        public void Work(House house)
        {
            if (CheckAndBuildPart(house, house.Basement)) return;

            foreach (var wall in house.Walls)
            {
                if (CheckAndBuildPart(house, wall)) return;
            }

            foreach (var window in house.Windows)
            {
                if (CheckAndBuildPart(house, window)) return;
            }

            if (CheckAndBuildPart(house, house.Door)) return;
            CheckAndBuildPart(house, house.Roof);
        }
    }

    internal class TeamLeader : IWorker
    {
        public string FirstName { get; }
        public string LastName { get; }

        public TeamLeader(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void Work(House house)
        {
            int partsBuilt = 0;

            foreach (var part in house.Parts)
            {
                if (part.IsBuilt)
                {
                    partsBuilt++;
                }
            }
            Console.WriteLine($"Team leader {FirstName} {LastName} reports: {partsBuilt} out of {house.TotalParts} parts built.");
        }
    }
}
