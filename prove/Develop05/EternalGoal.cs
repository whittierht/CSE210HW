using System;

public class EternalGoal : Goal
{
    public EternalGoal(int points, string name, string description)
        : base(points, name, description)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();


    }

    public override bool IsComplete()
    {
        return false;
        
    }

    public override string GetDetailsString()
    {


        return $"[ ] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}