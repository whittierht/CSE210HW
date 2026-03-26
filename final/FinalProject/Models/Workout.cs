namespace FitnessTrackerProject.Models
{
    public abstract class Workout
    {
        private string _name;
        private string _muscleGroup;

        public Workout(string name, string muscleGroup)
        {
            

        }

        public string GetName()
        {
            return "";
        }

        public string GetMuscleGroup()
        {
            return "";
            
        }

        public abstract double GetCaloriesBurned();

        public abstract string GetSummary();
    }
}