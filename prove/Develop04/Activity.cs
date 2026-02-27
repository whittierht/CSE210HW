using System;

namespace Develop04
{
    abstract class Activity
    {
        private string  _name;
        private string  _description;
        private int     _duration;

        protected Activity(string name ,  string description)
        {
            

            
        }


        public string GetName()
        {
            return "";
        }

        public string GetDescription()
        {
            return "";
        }

        public int GetDuration()
        {
            return 0;
        }


        protected void SetDuration(int seconds)
        {
        }

        protected void DisplayStartMessage()
        {
        }


        protected void DisplayEndMessage()
        {
        }

        protected void ShowSpinner(int seconds)
        {
        }

        protected void ShowCountdown(int seconds)
        {
        }

        public abstract void Run();
    }
}