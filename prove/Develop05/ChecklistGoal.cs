using System;

public class ChecklistGoal : Goal
{
    private int _progress;
    private int _amount;
    private int _bonus;

    public ChecklistGoal(int points, string name, string description, int amount, int bonus, int progress)
        : base(points, name, description)
    {
        _amount = amount;

        _bonus = bonus;

        _progress = progress;
    }

    public override int RecordEvent()
    {
        _progress++;

        if (_progress >= _amount)
        {
            return GetPoints() + _bonus;



        }

        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _progress >= _amount;
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";

        return $"{checkbox} {GetName()} ({GetDescription()}) -- Completed {_progress}/{_amount} times";
    }

    public override string GetStringRepresentation()
    {
        
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_amount}|{_progress}";
    }
}