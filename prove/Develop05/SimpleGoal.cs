public class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string desc, int points, bool status): base (name, desc, points, status, "SimpleGoal") {}
    public SimpleGoal() : base() {}
    public override void CreateGoal()
    {
        
    }
    public override int RecordEvent()
    {
        return MarkComplete();
    }
}