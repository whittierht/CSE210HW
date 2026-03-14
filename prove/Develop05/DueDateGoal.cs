//This is my stretch portion, this is a due date goal, if you don't finish it by the due date, you lost your points.
using System;

public class DueDateGoal : Goal
{
    private DateTime _dueDate;
    private bool _isComplete;

    public DueDateGoal(int points, string name, string description, DateTime dueDate, bool isComplete)
        : base(points, name, description)
    {
        _dueDate = dueDate;

        _isComplete = isComplete;

    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }

        _isComplete = true;

        if (DateTime.Today <= _dueDate.Date)
        {
            return GetPoints();
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";


        string dueText = _dueDate.ToString("MMMM d, yyyy");

        if (!_isComplete && DateTime.Today > _dueDate.Date)
        {


            return $"{checkbox} {GetName()} ({GetDescription()}) -- Due: {dueText} -- Expired";
        }

        return $"{checkbox} {GetName()} ({GetDescription()}) -- Due: {dueText}";
    }

    public override string GetStringRepresentation()
    {
        return $"DueDateGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_dueDate:yyyy-MM-dd}|{_isComplete}";
    }
}