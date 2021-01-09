using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstConsoleApplication
{
    class Program
    {
        private static void GetUserNameAndLocation()
        {
            // Create new instance of Person class and give a variable name of "person"
            Person person = new Person();

            // Ask user "What is your name?" and assign their response to the name variable.
            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();

            // Reply and prompt the user with "Hi, ____! Where are you from?" Assign their response to the location attribute.
            Console.WriteLine($"Hi, {person.name}! Where are you from?");
            person.location = Console.ReadLine();

            // Reply and prompt user with "I have never been to...Press any key to continue..." 
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. Press any key to continue...");
            Console.ReadKey();
        }

        private static void ChristmasCountdown(DateTime currentDate)
        {
            // Output the current date, but not the current time
            Console.WriteLine($"Today's date is: {currentDate.ToString("D")}");

            // Create variable name to store the calculated value of the number of days until Christmas as a whole number
            DateTime christmasDate = new DateTime(2021, 12, 25);
            int daysTilChristmas = (christmasDate - currentDate).Days; 

            // Output varaible 
            Console.WriteLine($"There are {daysTilChristmas} days until Christmas 2021!");

            // Prompt the user to press any key to continue and wait to proceed until a key is pressed
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            GetUserNameAndLocation();

            DateTime currentDate = DateTime.Today;
            ChristmasCountdown(currentDate);

            GlazerApp.RunExample();

            // Prompt user to press any key before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
