using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    class GlazerApp
    {
        public static void RunExample()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            // Prompt user for width
            Console.WriteLine("What is the width of the window?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            // Prompt user for height
            Console.WriteLine("What is the height of the window?");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            // Output the results in 2 different lines
            Console.WriteLine("\nThe length of the wood is " + woodLength + " feet");
            Console.WriteLine("\nThe area of the glass is " + glassArea + " square metres");
        }
    }
}
