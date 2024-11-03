using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    public class GroundTransport : Transport
    {
        public override string Name => "Ground transport";
    }

    public class Car : GroundTransport
    {
        public override string Name => "Car";
    }
    public class Horse : GroundTransport
    {
        public override string Name => "Horse";
    }
    public class Train : GroundTransport
    {
        public override string Name => "Train";
    }
}
