using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    public class AirTransport : Transport
    {
        public override string Name => "Air transport";
    }

    public class Airplane : AirTransport
    {
        public override string Name => "Airplane";
    }
    public class Helicopter : AirTransport
    {
        public override string Name => "Helicopter";
    }
    public class Airship : AirTransport
    {
        public override string Name => "Airship";
    }
}
