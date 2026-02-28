using System;
using System.Collections.Generic;

namespace Develop04
{
    class ListingActivity : Activity
    {
        private List<string>  _prompts;

        
        private Random        _random;

        public ListingActivity()
            : base("Listing Activity" ,  "This activity helps you focus on the positive side of things by making a list.")
        {
            


        }

        public override void Run()
        {

        }

        private string GetRandomPrompt()
        {
            return "";



        }
    }
}