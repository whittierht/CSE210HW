using System;

namespace Develop04
{
    class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base(
                "Breathing Activity",

                "This activity will help you relax by walking you through breathing in and out slowly."
              )
        {
        }



        public override void Run()
        {
            DisplayStartMessage();


            int timeRemaining = GetDuration();


            while (timeRemaining > 0)
            {
                Console.WriteLine();
                Console.Write("Breathe in... ");

                ShowCountdown(4);

                Console.WriteLine();
                Console.Write("Breathe out... ");

                ShowCountdown(4);

                Console.WriteLine();

                timeRemaining -= 8;
            }


            DisplayEndMessage();
        }
    }
}