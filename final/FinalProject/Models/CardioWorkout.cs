namespace FitnessTrackerProject.Models
{
    public class CardioWorkout : Workout
    {
        private int _minutes;
        private double _caloriesPerMinute;

        public CardioWorkout(string name, string muscleGroup, int minutes, double caloriesPerMinute)
            : base(name, muscleGroup)
        {
            _minutes = minutes;
            _caloriesPerMinute = caloriesPerMinute;
        }

        public int GetMinutes()
        {
            return _minutes;
        }

        public double GetCaloriesPerMinute()
        {
            return _caloriesPerMinute;
        }

        public override double GetCaloriesBurned()
        {
            return _minutes * _caloriesPerMinute;
        }

        public override string GetSummary()
        {
            return $"{GetName()} ({GetMuscleGroup()}) - Minutes: {_minutes}, Calories Burned: {GetCaloriesBurned()}";
        }

    }
}