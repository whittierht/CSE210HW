using System;

public class EternalGoal : Goal
{
    public EternalGoal(int points, string name, string description)
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