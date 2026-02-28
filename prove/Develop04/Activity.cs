using System;
using System.Threading;

namespace Develop04
{
    abstract class Activity
    {
        private string _name;
        private string _description;
        private int    _duration;

        protected Activity(string name, string description)
        {
            _name        = name;
            _description = description;
            _duration    = 0;
        }

        public string GetName()
        {


            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public int GetDuration()
        {
            return _duration;
        }

        protected void SetDuration(int seconds)
        {



            _duration = seconds;
        }

        protected void DisplayStartMessage()
        {
            Console.Clear();

            Console.WriteLine($"Welcome to the {GetName()}.");
            Console.WriteLine();
            Console.WriteLine(GetDescription());
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session? ");
            string input = Console.ReadLine() ?? "0";

            int seconds = 0;
            int.TryParse(input, out seconds);

            if (seconds < 0)
            {
                seconds = 0;
            }

            SetDuration(seconds);

            Console.WriteLine();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
            Console.WriteLine();
        }

        protected void DisplayEndMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            ShowSpinner(3);

            Console.WriteLine();
            Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetName()}.");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            string[] frames = { "|", "/", "-", "\\" };

            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            int index = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write(frames[index]);
                Thread.Sleep(200);
                Console.Write("\b");

                index++;

                if (index >= frames.Length)
                {


                    index = 0;
                }
            }
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {

                
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public abstract void Run();
    }
}