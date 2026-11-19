class Program
{
    static void Main(string[] args)
    {
        SimpleGoal newGoal = new SimpleGoal();
        Console.WriteLine(newGoal.GetConsoleString());
        newGoal.RecordEvent();
        Console.WriteLine(newGoal.GetConsoleString());
    }
}