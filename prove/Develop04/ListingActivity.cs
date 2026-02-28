using System;
using System.Collections.Generic;

namespace Develop04
{
    class ListingActivity : Activity
    {
        private List<string> _prompts;

        private Random _random;



        public ListingActivity()
            : base(
                "Listing Activity",

                "This activity will help you reflect on the good things in your life by having you list as many things as you can."
              )
        {
            _random = new Random();


            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this recently?",
                "Who are some of your personal heroes?"
            };
        }



        public override void Run()
        {
            DisplayStartMessage();


            Console.WriteLine();
            Console.WriteLine(GetRandomPrompt());

            Console.WriteLine();
            Console.WriteLine("You may begin in:");
            Console.WriteLine();

            ShowCountdown(15);

            Console.WriteLine();


            int count = 0;

            DateTime end = DateTime.Now.AddSeconds(GetDuration());


            while (DateTime.Now < end)
            {
                Console.Write("> ");
                Console.ReadLine();

                count++;
            }


            Console.WriteLine();
            Console.WriteLine($"You listed {count} items.");
            Console.WriteLine();


            DisplayEndMessage();
        }



        private string GetRandomPrompt()
        {
            return _prompts[_random.Next(_prompts.Count)];
        }
    }
}