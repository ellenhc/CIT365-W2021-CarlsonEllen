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
        const int DRAWER_MIN = 0;
        const int DRAWER_MAX = 7;

        private int width;
        public int Width
        {
            get { return width; }
        }

        private int depth;
        public int Depth
        {
            get { return depth; }
        }

        private int drawers;
        public int Drawers
        {
            get { return drawers; }
        }

        private DesktopMaterial surfaceMaterial;
        public DesktopMaterial SurfaceMaterial
        {
            get { return surfaceMaterial; }
        }


        //Desk constructor
        public Desk(int deskWidth, int deskDepth, int numDrawers, DesktopMaterial surfaceMaterial)
        {
            width = deskWidth;
            depth = deskDepth;
            drawers = numDrawers;
            this.surfaceMaterial = surfaceMaterial;
        }

        public int surfaceArea()
        {
            int area = width * depth;
            return area;
        }
    }
}
