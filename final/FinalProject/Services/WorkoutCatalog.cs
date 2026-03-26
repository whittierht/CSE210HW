using System.Collections.Generic;
using FitnessTrackerProject.Models;

namespace FitnessTrackerProject.Services
{
    public class WorkoutCatalog
    {
        private List<string> _muscleGroups;
        private List<string> _strengthOptions;
        private List<string> _cardioOptions;

        public WorkoutCatalog()
        {
        }

        public void DisplayMuscleGroups()
        {
        }

        public void DisplayWorkoutOptions(string muscleGroup)
        {
        }

        public StrengthWorkout CreateStrengthWorkout(int choice, int sets)
        {
            return null;
        }

        public CardioWorkout CreateCardioWorkout(int choice, int minutes)
        {
            return null;
        }
    }
}