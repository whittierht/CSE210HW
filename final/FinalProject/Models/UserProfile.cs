namespace FitnessTrackerProject.Models
{
    public class UserProfile
    {
        private string _name;
        private int _age;
        private double _heightInches;
        private double _weightInPounds;


        public UserProfile(string name, int age, double heightInches, double weightInPounds)
        {
            _name = name;
            _age = age;
            _heightInches = heightInches;
            _weightInPounds = weightInPounds;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        public double GetHeight()
        {
            return _heightInches;
        }

        public double GetWeight()
        {
            return _weightInPounds;
        }


        public string GetSummary()
        {
            return $"{_name} - Age: {_age}, Height: {_heightInches} inches, Weight: {_weightInPounds} lbs";
        }
    }
}