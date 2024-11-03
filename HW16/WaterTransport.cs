using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    public class WaterTransport : Transport
    {
        public override string Name => "Water transport";
    }

    public class TankerShip : WaterTransport
    {
        public override string Name => "Tanker ship";
    }
    public class Boat : WaterTransport
    {
        public override string Name => "Boat";
    }
    public class MotorShip : WaterTransport
    {
        public override string Name => "Motor ship";
    }
}
