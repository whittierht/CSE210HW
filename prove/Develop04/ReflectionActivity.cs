using System;
using System.Collections.Generic;

namespace Develop04
{
    class ReflectionActivity : Activity
    {
        private List<string> _prompts;

        private List<string> _questions;

        private Random _random;



        public ReflectionActivity()
            : base(
                "Reflection Activity",

                "This activity will help you reflect on times in your life when you have shown strength."
              )
        {
            _random = new Random();


            _prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something selfless."
            };


            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "How did you feel when it was complete?",
                "What did you learn about yourself through this experience?",
                "How can you use this strength again in the future?"
            };
        }



        public override void Run()
        {
            DisplayStartMessage();


            Console.WriteLine();
            Console.WriteLine(GetRandomPrompt());

            Console.WriteLine();
            Console.WriteLine("Reflect on the following questions:");
            Console.WriteLine();


            DateTime end = DateTime.Now.AddSeconds(GetDuration());


            while (DateTime.Now < end)
            {
                Console.WriteLine();
                Console.Write("> " + GetRandomQuestion() + " ");

                ShowSpinner(15);

                Console.WriteLine();
            }


            DisplayEndMessage();
        }



        private string GetRandomPrompt()
        {
            return _prompts[_random.Next(_prompts.Count)];
        }


        private string GetRandomQuestion()
        {
            return _questions[_random.Next(_questions.Count)];
        }
    }
}