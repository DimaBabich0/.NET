using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW21
{
    internal class FootballTeam<T> : IEnumerable<T> where T : FootballPlayer
    {
        public string Title { get; private set; }
        public T[] Players { get; private set; }

        public FootballTeam(string title, int count)
        {
            Title = title;
            Players = new T[count];
        }
        public void Print()
        {
            Console.WriteLine($"\tTeam \"{Title}\"");
            Console.WriteLine($"\tPlayers:");
            foreach (var player in this)
            {
                if (player != null)
                {
                    Console.WriteLine($"Name: {player.Name} {player.LastName}; Age: {player.Age}");
                }
            }
        }

        public void Add(T player)
        {
            for (int i = 0; i < Players.Length; i++)
            {
                if (Players[i] == null)
                {
                    Players[i] = player;
                    return;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var player in Players)
            {
                if (player != null)
                {
                    yield return player;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class FootballPlayer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public FootballPlayer(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
    }
}
