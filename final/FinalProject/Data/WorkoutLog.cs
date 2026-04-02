using System.Collections.Generic;
using FitnessTrackerProject.Models;

namespace FitnessTrackerProject.Data
{
    public class WorkoutLog
    {
        private List<Workout> _workouts;

        public WorkoutLog()
        {
            _workouts = new List<Workout>();
        }

        public void AddWorkout(Workout workout)
        {
            _workouts.Add(workout);
        }

        public List<Workout> GetWorkoutHistory()
        {
            return _workouts;
        }

        public double GetTotalCaloriesBurned()
        {
            double total = 0;

            foreach (Workout workout in _workouts)
            {
                total += workout.GetCaloriesBurned();
            }

            return total;
        }

        public string GetSummary()
        {
            string summary = "";

            if (_workouts.Count == 0)
            {
                return "No workouts logged yet.";
            }

            foreach (Workout workout in _workouts)
            {
                summary += workout.GetSummary() + "\n";
            }

            summary += "\nTotal Calories Burned: " + GetTotalCaloriesBurned();

            return summary;
        }
    }
}