using System;
using System.Collections.Generic;
using FitnessTrackerProject.Models;



namespace FitnessTrackerProject.Services
{
    public class WorkoutCatalog
    {
        private List<string> _strengthMuscleGroups;
        private List<string> _cardioMuscleGroups;

        public WorkoutCatalog()
        {
            _strengthMuscleGroups = new List<string>
            {
                "Chest",
                "Back",
                "Legs",
                "Arms",
                "Shoulders",
                "Core"


            };

            _cardioMuscleGroups = new List<string>
            {
                "Legs",
                "Core"

            };
        }

        public void DisplayStrengthMuscleGroups()
        {
            for (int i = 0; i < _strengthMuscleGroups.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_strengthMuscleGroups[i]}");
            }
        }

        public void DisplayCardioMuscleGroups()
        {
            for (int i = 0; i < _cardioMuscleGroups.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_cardioMuscleGroups[i]}");
            }
        }

        public string GetStrengthMuscleGroupByChoice(int choice)
        {
            if (choice >= 1 && choice <= _strengthMuscleGroups.Count)
            {
                return _strengthMuscleGroups[choice - 1];
            }

            return "";
        }

        public string GetCardioMuscleGroupByChoice(int choice)
        {
            if (choice >= 1 && choice <= _cardioMuscleGroups.Count)
            {
                return _cardioMuscleGroups[choice - 1];


            }

            return "";
        }

        public void DisplayStrengthOptions(string muscleGroup)
        {
            if (muscleGroup == "Chest")
            {
                Console.WriteLine("1. Bench Press");
                Console.WriteLine("2. Push Ups");
            }
            else if (muscleGroup == "Back")
            {
                Console.WriteLine("1. Pull Ups");
                Console.WriteLine("2. Rows");
            }
            else if (muscleGroup == "Legs")
            {
                Console.WriteLine("1. Squats");
                Console.WriteLine("2. Lunges");
            }
            else if (muscleGroup == "Arms")
            {
                Console.WriteLine("1. Bicep Curls");
                Console.WriteLine("2. Tricep Extensions");
            }
            else if (muscleGroup == "Shoulders")
            {
                Console.WriteLine("1. Shoulder Press");
                Console.WriteLine("2. Lateral Raises");
            }
            else if (muscleGroup == "Core")
            {
                Console.WriteLine("1. Sit Ups");
                Console.WriteLine("2. Plank");

            }
        }

        public void DisplayCardioOptions(string muscleGroup)
        {
            if (muscleGroup == "Legs")
            {
                Console.WriteLine("1. Running");
                Console.WriteLine("2. Cycling");
            }
            else if (muscleGroup == "Core")
            {
                Console.WriteLine("1. Jump Rope");
            }
        }

        public StrengthWorkout CreateStrengthWorkout(int choice, int sets, string muscleGroup)
        {
            //I need to workout more frequently, but the best way I found is thorugh muscle groups
            if (muscleGroup == "Chest")
            {
                if (choice == 1)
                {
                    return new StrengthWorkout("Bench Press", muscleGroup, sets, 8);
                }
                else if (choice == 2)
                {

                    return new StrengthWorkout("Push Ups", muscleGroup, sets, 6);
                }
            }
            else if (muscleGroup == "Back")
            {
                if (choice == 1)
                {
                    return new StrengthWorkout("Pull Ups", muscleGroup, sets, 7);

                }
                else if (choice == 2)
                {
                    return new StrengthWorkout("Rows", muscleGroup, sets, 8);
                }
            }
            else if (muscleGroup == "Legs")
            {
                if (choice == 1)
                {
                    return new StrengthWorkout("Squats", muscleGroup, sets, 10);

                }
                else if (choice == 2)
                {
                    return new StrengthWorkout("Lunges", muscleGroup, sets, 8);
                }
            }
            else if (muscleGroup == "Arms")
            {
                if (choice == 1)
                {
                    return new StrengthWorkout("Bicep Curls", muscleGroup, sets, 5);
                }
                else if (choice == 2)
                {
                    return new StrengthWorkout("Tricep Extensions", muscleGroup, sets, 5);
                }
            }
            else if (muscleGroup == "Shoulders")
            {
                if (choice == 1)
                {
                    return new StrengthWorkout("Shoulder Press", muscleGroup, sets, 7);
                }
                else if (choice == 2)
                {
                    return new StrengthWorkout("Lateral Raises", muscleGroup, sets, 5);
                }
            }
            else if (muscleGroup == "Core")
            {
                if (choice == 1)
                {
                    return new StrengthWorkout("Sit Ups", muscleGroup, sets, 4);
                }
                else if (choice == 2)
                {
                    return new StrengthWorkout("Plank", muscleGroup, sets, 3);
                }
            }

            return null;
        }

        public CardioWorkout CreateCardioWorkout(int choice, int minutes, string muscleGroup)
        {
            if (muscleGroup == "Legs")
            {
                if (choice == 1)
                {
                    return new CardioWorkout("Running", muscleGroup, minutes, 10);
                }
                else if (choice == 2)
                {
                    return new CardioWorkout("Cycling", muscleGroup, minutes, 8);
                    
                }
            }
            else if (muscleGroup == "Core")
            {
                if (choice == 1)
                {
                    return new CardioWorkout("Jump Rope", muscleGroup, minutes, 12);
                    
                }
            }

            return null;
        }
    }
}