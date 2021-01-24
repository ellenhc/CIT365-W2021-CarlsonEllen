using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Carlson
{
    //Create an enum type for the desktop materials in the Desk.cs file, but not the class.
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    public class Desk
    {
        //Set the width and depth min and max constraints as constants stored within the Desk class
        const int WIDTH_MIN = 24;
        const int WIDTH_MAX = 96;
        const int DEPTH_MIN = 12;
        const int DEPTH_MAX = 48;

        private int width;
        private int depth;
        private int drawer;

        

        //Desk constructor
        public Desk(int deskWidth, int deskDepth, int numDrawers, DesktopMaterial surfaceMaterial)
        {
            width = deskWidth;
            depth = deskDepth;
            drawer = numDrawers;
        }

        public int GetDeskWidth()
        {
            return width;
        }

        public int GetDeskDepth()
        {
            return depth;
        }
    }
}
