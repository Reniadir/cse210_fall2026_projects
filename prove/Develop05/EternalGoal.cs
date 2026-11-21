using System.ComponentModel.DataAnnotations.Schema;

public class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;

    public EternalGoal() : base()
    {
        _numberOfCompletions = 0;
    }

    public EternalGoal(string name, string description, int points, bool status, int completions)
        : base(name, description, points, status, nameof(EternalGoal))
    {
        _numberOfCompletions = completions;
    }

    public int Completions()
    {
        return _numberOfCompletions;
    } 

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        return GetGoalPoints();
    }

    public override string GetConsoleString()
    {
        return $"[ ] - {GetGoalType()}, Goal name: {GetGoalName()} Desc: {GetGoalDesc()} Completeions: {_numberOfCompletions} PointsPer: {GetGoalPoints()}";
    }

    public override string GetFileSystemString()
    {
        return $"{GetGoalName}#{GetGoalDesc}#{GetGoalPoints}#{GetGoalPoints}#{IsComplete}#{_numberOfCompletions}";
    }
}