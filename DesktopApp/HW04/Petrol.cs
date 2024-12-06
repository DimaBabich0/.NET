using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    internal class Petrol
    {
        public string Title { get; private set; }
        public double Price { get; private set; }

        public Petrol(string title, double price)
        {
            Title = title;
            Price = price;
        }
    }
}
