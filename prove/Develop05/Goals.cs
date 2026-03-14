using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;




    public Goal(int points, string name, string description)
    {
        _points = points;
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual int RecordEvent()
    {
        return _points;
    }

    public virtual bool IsComplete()
    {
        return false;
    }




    public virtual string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_name}|{_description}|{_points}";
    }
}