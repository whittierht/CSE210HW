using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private List<Goal> _goals = new List<Goal>();
    private int _points = 0;

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    void Run()
    {
        int choice = -1;

        while (choice != 6)
        {
            DisplayPoints();
            DisplayMenu();
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                CreateGoal();
            else if (choice == 2)
                ListGoals();
            else if (choice == 3)
                SaveGoals("goals.txt");
            else if (choice == 4)
                LoadGoals("goals.txt");
            else if (choice == 5)
                RecordEvent();
        }
    }

    void DisplayMenu()
    {
        Console.WriteLine("\nMenu Options:");

        Console.WriteLine("1. Create New Goal");

        Console.WriteLine("2. List Goals");

        Console.WriteLine("3. Save Goals");

        Console.WriteLine("4. Load Goals");

        Console.WriteLine("5. Record Event");

        Console.WriteLine("6. Quit");

        Console.Write("Select a choice: ");
    }

    void DisplayPoints()
    {
        Console.WriteLine($"\nYou have {_points} points.");
    }

    void CreateGoal()
    {
        Console.WriteLine("Goal Types:");

        Console.WriteLine("1. Simple Goal");

        Console.WriteLine("2. Eternal Goal");

        Console.WriteLine("3. Checklist Goal");

        Console.WriteLine("4. Due Date Goal");

        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");

        string name = Console.ReadLine();

        Console.Write("Description: ");

        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(points, name, description, false));

        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(points, name, description));

        }
        else if (type == 3)
        {
            Console.Write("How many times to complete: ");

            int amount = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");

            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(points, name, description, amount, bonus, 0));
        }
        else if (type == 4)
        {
            Console.Write("How many days would you like to complete the goal? ");

            int days = int.Parse(Console.ReadLine());

            DateTime dueDate = DateTime.Today.AddDays(days);

            Console.WriteLine($"Due date set to {dueDate:MMMM d, yyyy}.");

            _goals.Add(new DueDateGoal(points, name, description, dueDate, false));
        }


    }

    void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");

        }
    }

    void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        ListGoals();

        int choice = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[choice].RecordEvent();
        _points += earned;

        Console.WriteLine($"You earned {earned} points!");

        // probably could clean this up later but it works, I would like it to stay on the screen so you can record mutliple events at a time
    }

    void SaveGoals(string fileName)
    {
        using (StreamWriter output = new StreamWriter(fileName))
        {
            output.WriteLine(_points);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    void LoadGoals(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("\nNo save file found.");
            return;
        }

        Console.WriteLine("\nSave File Loaded");
        string[] lines = File.ReadAllLines(fileName);

        _points = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(int.Parse(parts[3]), parts[1], parts[2], bool.Parse(parts[4])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(int.Parse(parts[3]), parts[1], parts[2]));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(
                    int.Parse(parts[3]),
                    parts[1],
                    parts[2],
                    int.Parse(parts[5]),
                    int.Parse(parts[4]),
                    int.Parse(parts[6])
                ));
            }
            else if (type == "DueDateGoal")
            {
                _goals.Add(new DueDateGoal(
                    int.Parse(parts[3]),
                    parts[1],
                    parts[2],
                    DateTime.Parse(parts[4]),
                    bool.Parse(parts[5])
                ));
            }
        }
    }
}