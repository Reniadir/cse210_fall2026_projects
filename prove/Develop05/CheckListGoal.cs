public class CheckListGoal : BaseGoal
{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;

    public CheckListGoal() : base()
    {
        _numberOfCompletions = 0;
        _maxGoals = 1;
        _bonusPoints = 0;
    }

    public CheckListGoal(
        string name,
        string description,
        int points,
        bool status,
        int numComplete,
        int maxGoal,
        int bonusPoints)
        : base(name, description, points, status, nameof(CheckListGoal))
    {
        _numberOfCompletions = numComplete;
        _maxGoals = maxGoal;
        _bonusPoints = bonusPoints;
    }

    public void SetMaxGoal()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _maxGoals = int.Parse(Console.ReadLine() ?? "1");
    }

    public void SetBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine() ?? "0");
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _numberOfCompletions++;
        int earned = GetGoalPoints();

        if (_numberOfCompletions >= _maxGoals)
        {
            MarkComplete();
            earned += _bonusPoints;
        }

        return earned;
    }

    public override string GetConsoleString()
    {
        string qcomplete = " ";
        if (IsComplete())
        {
            qcomplete = "X";
        }
        return $"[{qcomplete}] - {GetGoalType()}, Goal name: {GetGoalName()} Desc: {GetGoalDesc()} Completions: {_numberOfCompletions}/{_maxGoals} PointsPer: {GetGoalPoints()} Bonus: {_bonusPoints}";
    }

    public override string GetFileSystemString()
    {
        return $"{GetGoalName}#{GetGoalDesc}#{GetGoalPoints}#{IsComplete()}#{GetGoalType}#{_numberOfCompletions}#{_maxGoals}#{_bonusPoints}";
    }
}