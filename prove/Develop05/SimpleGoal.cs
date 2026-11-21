public class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string desc, int points, bool status): base (name, desc, points, status, "SimpleGoal") {}
    public SimpleGoal() : base() {}
    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }
        MarkComplete();
        return GetGoalPoints();
    }
}