using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity activity = null;

            string choice = "";

            while (choice != "4")
            {
                Console.Clear();

                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflection Activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice: ");

                choice = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    activity = new BreathingActivity();
                    activity.Run();
                }
                else if (choice == "2")
                {
                    activity = new ReflectionActivity();
                    activity.Run();
                }
                else if (choice == "3")
                {
                    activity = new ListingActivity();
                    activity.Run();
                }
                else if (choice == "4")
                {
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Not a choice, enter to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}