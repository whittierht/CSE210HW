using System;
using FitnessTrackerProject.Core;

namespace FitnessTrackerProject
{
    class Program
    {
        //This program lets users track workouts and estimate calories burned
        //It's cool cause you can eat more if you workout
        //Also with the profile section, it will calculate how much base calories you should have to lose your desired weight, 
        //and the more you workout, the more calories you can eat.
        //Not sure if the science and math are super correct, but I think it is pretty similar to what other fitness trackers have told me.
        //I'm finishing Friday because I do all my coding on my desktop and not my laptop, I wanted to add more workouts and 
        //the ability to save workouts and everything. But I can always continute on it after this class.
        static void Main(string[] args)
        {
            FitnessTracker app = new FitnessTracker();
            app.Run();
        }
    }
}