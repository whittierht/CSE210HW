namespace FitnessTrackerProject.Models
{
    public class StrengthWorkout : Workout
    {
        private int _sets;
        private double _caloriesPerSet;

        public StrengthWorkout(string name, string muscleGroup, int sets, double caloriesPerSet)
            : base(name, muscleGroup)
        {
        }

        public int GetSets()
        {
            return 0;
        }

        public override double GetCaloriesBurned()
        {
            return 0;
        }

        public override string GetSummary()
        {
            return "";
        }
    }
}