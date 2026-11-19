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
    private void SetGoalDesc()
    {
        Console.Write("Please enter the description of your Goal: ");
        _desc = Console.ReadLine();
    }
    private void SetGoalPoints()
    {
        Console.Write($"Please enter the number of points for goal {_name}: ");
        _points = int.Parse(Console.ReadLine());
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
    public int MarkComplete()
    {
        _status = true;
        return _points;

    }
    public abstract void CreateGoal();
    public abstract int RecordEvent();
}