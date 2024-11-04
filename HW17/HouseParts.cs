using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    internal interface IPart
    {
        string PartName { get; }
        bool IsBuilt { get; set; }
    }

    internal class Basement : IPart
    {
        public bool IsBuilt { get; set; } = false;
        public string PartName => "Basement";
    }

    internal class Wall : IPart
    {
        public bool IsBuilt { get; set; } = false;
        public string PartName => "Wall";
    }

    internal class Door : IPart
    {
        public bool IsBuilt { get; set; } = false;
        public string PartName => "Door";
    }

    internal class Window : IPart
    {
        public bool IsBuilt { get; set; } = false;
        public string PartName => "Window";
    }

    internal class Roof : IPart
    {
        public bool IsBuilt { get; set; } = false;
        public string PartName => "Roof";
    }
}
