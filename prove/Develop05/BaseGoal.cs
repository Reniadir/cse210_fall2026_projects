class BaseGoal
{
    private string _name;
    private string _desc;
    private int _points;
    public BaseGoal()
    {
        GetGoalName();
        GetGoalDesc();
        GetGoalPoints();
    }
    private void GetGoalName()
    {
        Console.Write("Please enter the name of your goal?");
        _name = Console.ReadLine();
    }
    private void GetGoalDesc()
    {
        Console.Write("Please enter the description of your Goal: ");
        _desc = Console.ReadLine();
    }
    private void GetGoalPoints()
    {
        Console.Write($"Please enter the number of points for goal {_name}: ");
        _points = int.Parse(Console.ReadLine());
    }
    public string GetConsoleString()
    {
        return $"Goal name:[ ] {_name} Desc: {_desc} Points: {_points}";
    }
}