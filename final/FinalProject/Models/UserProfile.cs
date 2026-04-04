using System;
using System.IO;

namespace FitnessTrackerProject.Models
{
    public class UserProfile
    {
        private string _name;
        private int _age;
        private double _heightInches;
        private double _weightInPounds;
        private double _weeklyWeightGoal;


        public UserProfile(string name, int age, double heightInches, double weightInPounds, double weeklyWeightGoal)
        {
            _name = name;
            _age = age;
            _heightInches = heightInches;
            _weightInPounds = weightInPounds;
            _weeklyWeightGoal = weeklyWeightGoal;
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

        public double GetWeeklyGoal()
        {
            return _weeklyWeightGoal;
        }

        public string GetSummary()
        {
            return $"{_name} - Age: {_age}, Height: {_heightInches} inches, Weight: {_weightInPounds} lbs, Goal: Lose {_weeklyWeightGoal} lbs/week";
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(_name);
                outputFile.WriteLine(_age);
                outputFile.WriteLine(_heightInches);
                outputFile.WriteLine(_weightInPounds);
                outputFile.WriteLine(_weeklyWeightGoal);
            }
        }

        public static UserProfile LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return null;
            }

            string[] lines = File.ReadAllLines(fileName);

            if (lines.Length < 5)
            {
                return null;
            }

            string name = lines[0];
            int age = int.Parse(lines[1]);
            double height = double.Parse(lines[2]);
            double weight = double.Parse(lines[3]);
            double weeklyGoal = double.Parse(lines[4]);

            return new UserProfile(name, age, height, weight, weeklyGoal);
        }
    }
}