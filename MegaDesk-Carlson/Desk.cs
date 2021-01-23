using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Carlson
{
    //Create an enum type for the desktop materials in the Desk.cs file, but not the class.
    enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    class Desk
    {
        //Set the width and depth min and max constraints as constants stored within the Desk class
        const int WIDTH_MIN = 24;
        const int WIDTH_MAX = 96;
        const int DEPTH_MIN = 12;
        const int DEPTH_MAX = 48;
    }
}
