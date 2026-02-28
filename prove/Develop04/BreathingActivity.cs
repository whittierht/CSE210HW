using System;

namespace Develop04
{

    
    class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base("Breathing Activity" ,  "This activity helps you relax and helps you breath in and out to do so.")
        {



        }

        public override void Run()
        {
            
            DisplayStartMessage();

            int timeRemaining = GetDuration();




            DisplayEndMessage();

        }
    }
}