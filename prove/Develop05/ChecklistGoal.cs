using System;

public class ChecklistGoal : Goal
{
    private int _progress;
    private int _amount;

    private int _bonus;

    public ChecklistGoal(int points, string name, string description, int amount, int bonus, int progress)
        : base(points, name, description)
    {
    }

    public override int RecordEvent()
    {
        return 0;

    }

    public override bool IsComplete()
    {
        
        return false;
    }
}