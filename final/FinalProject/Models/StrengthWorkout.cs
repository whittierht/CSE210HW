namespace FitnessTrackerProject.Models
{
    public class StrengthWorkout : Workout
    {
        private int _sets;
        private double _caloriesPerSet;

        public StrengthWorkout(string name, string muscleGroup, int sets, double caloriesPerSet)
            : base(name, muscleGroup)
        {
            _sets = sets;
            _caloriesPerSet = caloriesPerSet;
        }

        public int GetSets()
        {
            return _sets;
        }

        public double GetCaloriesPerSet()
        {
            return _caloriesPerSet;
        }

        public override double GetCaloriesBurned()
        {
            return _sets * _caloriesPerSet;
        }


        public override string GetSummary()
        {
            return $"{GetName()} ({GetMuscleGroup()}) - Sets: {_sets}, Calories Burned: {GetCaloriesBurned()}";
        }
    }
}