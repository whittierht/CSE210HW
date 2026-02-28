using System;
using System.Collections.Generic;

namespace Develop04
{
    class ReflectionActivity : Activity
    {
        private List<string>  _prompts;
        
        private List<string>  _questions;
        private Random        _random;

        public ReflectionActivity()
            : base("Reflection Avtivity" ,  "This helps you reflect on times in your life to help you feel inspired.")
        {
            


        }

        public override void Run()
        {



        }

        private string GetRandomPrompt()
        {
            return "";
        }

        private string GetRandomQuestion()
        {
            return "";
        }
    }
}