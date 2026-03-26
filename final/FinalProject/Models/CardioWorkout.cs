namespace FitnessTrackerProject.Models
{
    public class CardioWorkout : Workout
    {
        private int _minutes;
        private double _caloriesPerMinute;

        public CardioWorkout(string name, string muscleGroup, int minutes, double caloriesPerMinute)
            : base(name, muscleGroup)
        {

            
        }


        public int GetMinutes()
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