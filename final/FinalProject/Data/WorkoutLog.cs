using System.Collections.Generic;
using FitnessTrackerProject.Models;

namespace FitnessTrackerProject.Data
{
    public class WorkoutLog
    {
        private List<Workout> _workouts;

        public WorkoutLog()
        {
            
        }

        public void AddWorkout(Workout workout)
        {
        }

        public double GetTotalCaloriesBurned()
        {
            return 0;

            
        }

        public List<Workout> GetWorkoutHistory()
        {
            return null;
        }

        public string GetSummary()
        {
            return "";
        }
    }
}