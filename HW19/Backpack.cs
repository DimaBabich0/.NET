using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19
{
    public class Item
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }

        public Item(string name, double weight, double volume)
        {
            Name = name;
            Weight = weight;
            Volume = volume;
        }
    }

    public delegate void AddObjectHandler(Item obj);
    public class Backpack
    {
        private string Color { get; set; }
        private string Manufacturer { get; set; }
        private string Fabric { get; set; }
        private double Weight { get; set; }
        private double Volume { get; set; }
        private List<Item> Objects;
        public event AddObjectHandler ObjectAdded;

        public Backpack(string color, string manufacturer, string fabric, double weight, double volume, List<Item> objects)
        {
            Color = color;
            Manufacturer = manufacturer;
            Fabric = fabric;
            Volume = volume;
            Objects = objects;
            Weight = Objects.Sum(obj => obj.Weight);
            ObjectAdded += OnObjectAdded;
        }

        public void AddObject(Item obj)
        {
            try
            {
                double currentVolume = GetBackpackVolume();
                if (currentVolume + obj.Volume > Volume)
                {
                    throw new Exception($"Backpack is full: can\'t add object \"{obj.Name}\"");
                }
                Objects.Add(obj);
                Weight += obj.Weight;
                ObjectAdded?.Invoke(obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}\n");
            }
        }
        private void OnObjectAdded(Item obj)
        {
            Console.WriteLine($"{obj.Name} added to the backpack");
        }
        public double GetBackpackVolume()
        {
            return Math.Round(Objects.Sum(obj => obj.Volume), 2);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"\tBackpack Info:");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Fabric: {Fabric}");
            Console.WriteLine($"Weight: {Math.Round(Weight, 2)}");
            Console.WriteLine($"Volume of items: {Math.Round(Objects.Sum(obj => obj.Volume), 2)}");
            Console.WriteLine($"Max volume: {Math.Round(Volume, 2)}\n");

            Console.WriteLine($"{Objects.Count} objects in the backpack:");
            foreach (Item obj in Objects)
            {
                Console.WriteLine($"{obj.Name} (weight: {Math.Round(obj.Weight, 2)}, volume: {Math.Round(obj.Volume, 2)})");
            }
            Console.WriteLine();
        }
    }
}
