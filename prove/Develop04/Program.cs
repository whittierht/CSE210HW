using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "5")
            {
                Console.Clear();


                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start reflection activity");
                Console.WriteLine("3. Start listing activity");
                Console.WriteLine("4. Start gratitude activity");
                //this is my exceeding the core requirements by adding the gratitude activity.
                Console.WriteLine("5. Quit");

                Console.WriteLine();
                Console.Write("Select a choice from the menu: ");

                choice = Console.ReadLine();


                Activity activity = null;


                if (choice == "1")
                {
                    activity = new BreathingActivity();
                }
                else if (choice == "2")
                {
                    activity = new ReflectionActivity();
                }
                else if (choice == "3")
                {
                    activity = new ListingActivity();
                }
                else if (choice == "4")
                {
                    activity = new GratitudeActivity();
                }
                else if (choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }


                if (activity != null)
                {
                    Console.WriteLine();
                    activity.Run();

                    Console.WriteLine();
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                }
            }
        }
    }
}