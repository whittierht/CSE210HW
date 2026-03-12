using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(int points, string name, string description)
    {


    }

    public string GetName()
    {
        return "";


    }

    public string GetDescription()
    {
        return "";
    }

    public int GetPoints()
    {
        return 0;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return "";

        
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}