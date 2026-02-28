// this is my addtion for the program. It's a new activity to show how fast you can think of things you are grateful for!

using System;

namespace Develop04
{
    class GratitudeActivity : Activity
    {
        public GratitudeActivity()
            : base("Gratitude Activity",
                   "This activity will help you focus on gratitude. Each time you think of something you are grateful for you press the space bar, think of as many as you can!")
        {
        }

        public override void Run()
        {
            DisplayStartMessage();

            Console.WriteLine();
            Console.WriteLine("Press the space bar each time you think of something you're grateful for.");


            Console.WriteLine();
            Console.Write("Starting in: ");
            ShowCountdown(3);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Go!");

            int count = 0;

            DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        count++;

                        Console.Write($"Count: {count}   ");
                        Console.Write("\r");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"You thought of {count} gratitude thoughts.");

            DisplayEndMessage();
        }
    }
}