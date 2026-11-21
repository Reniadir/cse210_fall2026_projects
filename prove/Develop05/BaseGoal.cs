public abstract class BaseGoal
{
    private string _name;
    private string _desc;
    private int _points;
    private bool _status;
    private string _goalType;
    public BaseGoal(string name, string desc, int points, bool status, string type)
    {
        _name = name;
        _desc = desc;
        _points = points;
        _status = status;
        _goalType = type;
    }
    public BaseGoal()
    {
        SetGoalName();
        SetGoalDesc();
        SetGoalPoints();
        _status = false;
        _goalType = base.ToString();
    }
    private void SetGoalName()
    {
        Console.Write("Please enter the name of your goal?");
        _name = Console.ReadLine();
    }
    public string GetGoalName()
    {
        return _name;
    }
    private void SetGoalDesc()
    {
        Console.Write("Please enter the description of your Goal: ");
        _desc = Console.ReadLine();
    }
    public string GetGoalDesc()
    {
        return _desc;
    }
    private void SetGoalPoints()
    {
        Console.Write($"Please enter the number of points for goal {_name}: ");
        _points = int.Parse(Console.ReadLine());
    }
    public int GetGoalPoints()
    {
        return _points;
    }
    public virtual string GetConsoleString()
    {
        string qcomplete = " ";
        if (_status)
        {
            qcomplete = "X";
        }
        return $"[{qcomplete}] - {_goalType}, Goal name: {_name} Desc: {_desc} Points: {_points}";
    }
    public virtual string GetFileSystemString()
    {
        return $"{_name}#{_desc}#{_points}#{_status}#{_goalType}";
    }
    public virtual string GetGoalType()
    {
        return $"{_goalType}";
    }
    public bool IsComplete()
    {
        return _status;
    }
    public void MarkComplete()
    {
        _status = true;
    }
    public abstract int RecordEvent();
}