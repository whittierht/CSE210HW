using System;
using FitnessTrackerProject.Models;
using FitnessTrackerProject.Services;
using FitnessTrackerProject.Data;

namespace FitnessTrackerProject.Core
{
    public class FitnessTracker
    {
        private UserProfile _user;
        private CalorieCalculator _calculator;
        private WorkoutLog _log;
        private WorkoutCatalog _catalog;

        public FitnessTracker()
        {
            _calculator = new CalorieCalculator();
            _log = new WorkoutLog();
            _catalog = new WorkoutCatalog();
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the Fitness Tracker");
            Console.WriteLine();

            LoadOrCreateProfile();
            ShowMainMenu();
        }

        public void ShowMainMenu()
        {
            string choice = "";

            while (choice != "6")
            {
                Console.WriteLine();
                Console.WriteLine("1. Add Workout");
                Console.WriteLine("2. View Workout Log");
                Console.WriteLine("3. View Calories");
                Console.WriteLine("4. Daily Summary");
                Console.WriteLine("5. Save Profile");
                Console.WriteLine("6. Quit");
                Console.Write("Choose: ");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    TrackWorkout();
                }
                else if (choice == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine(_log.GetSummary());
                }
                else if (choice == "3")
                {
                    TrackCalories();
                }
                else if (choice == "4")
                {
                    DisplayDailySummary();
                }
                else if (choice == "5")
                {
                    _user.SaveToFile("userprofile.txt");
                    Console.WriteLine("Profile saved.");
                }
                else if (choice == "6")
                {
                    _user.SaveToFile("userprofile.txt");
                    Console.WriteLine("Goodbye.");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }

        public void LoadOrCreateProfile()
        {
            Console.Write("Load saved profile? (yes/no): ");
            string choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                UserProfile loadedUser = UserProfile.LoadFromFile("userprofile.txt");

                if (loadedUser != null)
                {
                    _user = loadedUser;
                    Console.WriteLine("Profile loaded.");
                    Console.WriteLine(_user.GetSummary());
                    return;
                }

                Console.WriteLine("No saved profile found.");
            }

            CreateUserProfile();
        }

        public void CreateUserProfile()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            int age = ReadInt("Age: ");
            double height = ReadDouble("Height (inches): ");
            double weight = ReadDouble("Weight (lbs): ");
            double goal = ReadDouble("How many lbs do you want to lose per week? ");

            _user = new UserProfile(name, age, height, weight, goal);

            Console.WriteLine("Profile created.");
        }

        public void TrackWorkout()
        {
            Console.WriteLine();
            Console.WriteLine("1. Strength");
            Console.WriteLine("2. Cardio");
            Console.Write("Choose: ");
            string type = Console.ReadLine();

            if (type == "1")
            {
                Console.WriteLine();
                _catalog.DisplayStrengthMuscleGroups();
                string group = _catalog.GetStrengthMuscleGroupByChoice(ReadInt("Choose a muscle group number: "));

                if (group == "")
                {
                    Console.WriteLine("Invalid muscle group.");
                    return;
                }

                Console.WriteLine();
                _catalog.DisplayStrengthOptions(group);
                int choice = ReadInt("Choose a workout number: ");
                int sets = ReadInt("Enter number of sets: ");

                StrengthWorkout workout = _catalog.CreateStrengthWorkout(choice, sets, group);

                if (workout != null)
                {
                    _log.AddWorkout(workout);
                    Console.WriteLine("Workout added.");
                }
                else
                {
                    Console.WriteLine("Invalid workout.");
                }
            }
            else if (type == "2")
            {
                Console.WriteLine();
                _catalog.DisplayCardioMuscleGroups();
                string group = _catalog.GetCardioMuscleGroupByChoice(ReadInt("Choose a muscle group number: "));

                if (group == "")
                {
                    Console.WriteLine("Invalid muscle group.");
                    return;
                }

                Console.WriteLine();
                _catalog.DisplayCardioOptions(group);
                int choice = ReadInt("Choose a workout number: ");
                int minutes = ReadInt("Enter number of minutes: ");

                CardioWorkout workout = _catalog.CreateCardioWorkout(choice, minutes, group);

                if (workout != null)
                {
                    _log.AddWorkout(workout);
                    Console.WriteLine("Workout added.");
                }
                else
                {
                    Console.WriteLine("Invalid workout.");
                }
            }
            else
            {
                Console.WriteLine("Invalid workout type.");
            }
        }

        public void TrackCalories()
        {
            double baseC = _calculator.CalculateBaseCalories(_user);
            double adj = _calculator.CalculateAdjustedCalories(_user, _log);

            Console.WriteLine();
            Console.WriteLine($"Base Calories: {baseC:F0}");
            Console.WriteLine($"Calories After Goal + Workouts: {adj:F0}");
        }

        public void DisplayDailySummary()
        {
            Console.WriteLine();
            Console.WriteLine(_user.GetSummary());
            Console.WriteLine();
            Console.WriteLine(_log.GetSummary());
            Console.WriteLine();
            Console.WriteLine($"Target Calories: {_calculator.CalculateAdjustedCalories(_user, _log):F0}");
        }

        private int ReadInt(string prompt)
        {
            int val;

            while (true)
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out val))
                {
                    return val;
                }

                Console.WriteLine("Invalid.");
            }
        }

        private double ReadDouble(string prompt)
        {
            double val;

            while (true)
            {
                Console.Write(prompt);

                if (double.TryParse(Console.ReadLine(), out val))
                {
                    return val;
                }

                Console.WriteLine("Invalid.");
            }
        }
    }
}