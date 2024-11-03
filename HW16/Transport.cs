using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    public abstract class Transport
    {
        public abstract string Name { get; }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} is moving");
        }
    }
}
