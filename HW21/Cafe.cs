using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW21
{
    internal class Cafe<T> : IEnumerable<T> where T : Worker
    {
        public string Title { get; private set; }
        public T[] Workers { get; private set; }
        public Cafe(string title, int count)
        {
            Workers = new T[count];
            Title = title;
        }
        public void Print()
        {
            Console.WriteLine($"\tCafe \"{Title}\"");
            Console.WriteLine("\tWorkers:");
            foreach (var worker in this)
            {
                if (worker != null)
                {
                    Console.WriteLine($"Name: {worker.Name} {worker.LastName}; Age: {worker.Age}");
                }
            }
        }

        public void Add(T worker)
        {
            for (int i = 0; i < Workers.Length; i++)
            {
                if (Workers[i] == null)
                {
                    Workers[i] = worker;
                    return;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var worker in Workers)
            {
                if (worker != null)
                {
                    yield return worker;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Worker
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Worker(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
    }
}
