namespace FitnessTrackerProject.Models
{
    public abstract class Workout
    {
        private string _name;
        private string _muscleGroup;

        public Workout(string name, string muscleGroup)
        {
            _name = name;
            _muscleGroup = muscleGroup;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetMuscleGroup()
        {
            return _muscleGroup;
        }

        public abstract double GetCaloriesBurned();

        public abstract string GetSummary();
    }
}