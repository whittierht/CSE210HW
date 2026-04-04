using FitnessTrackerProject.Models;
using FitnessTrackerProject.Data;

namespace FitnessTrackerProject.Services
{
    public class CalorieCalculator
    {
        public double CalculateBaseCalories(UserProfile user)
        {
            double weight = user.GetWeight();
            double height = user.GetHeight();
            int age = user.GetAge();
            
            //this is a formula to extimate daily calories based on the users info. I'm not sure how accurate
            //it is, but hey, it works.
            double baseCalories = 66 + (6.23 * weight) + (12.7 * height) - (6.8 * age);

            return baseCalories;
        }

        public double CalculateAdjustedCalories(UserProfile user, WorkoutLog log)
        {
            double baseCalories = CalculateBaseCalories(user);
            double caloriesBurned = log.GetTotalCaloriesBurned();

            double deficit = user.GetWeeklyGoal() * 500;
            double adjusted = baseCalories + caloriesBurned - deficit;

            return adjusted;
        }
    }
}