using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(int points, string name, string description, bool isComplete)
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