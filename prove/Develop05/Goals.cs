class Goals
{
    private List<BaseGoal> _goals;
    private string _fileName;
    private int _totalScore;
    public Goals()
    {
        _goals = new List<BaseGoal>();
        _fileName = string.Empty;
        _totalScore = 0;
    }
    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }
    public void LoadGoals()
    {
        ObtainFileName("What is the filename for the goal file? ");
        if (!File.Exists(_fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(_fileName);
        if (lines.Length == 0) return;

        _goals.Clear();
        _totalScore = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('#');
            string type = parts[4];

            switch (type)
            {
                case nameof(SimpleGoal):
                    _goals.Add(new SimpleGoal(
                        parts[0],
                        parts[1],
                        int.Parse(parts[2]),
                        bool.Parse(parts[3])));
                    break;

                case nameof(EternalGoal):
                    _goals.Add(new EternalGoal(
                        parts[0],
                        parts[1],
                        int.Parse(parts[2]),
                        bool.Parse(parts[3]),
                        int.Parse(parts[5])));
                    break;
                    case nameof(CheckListGoal):
                    _goals.Add(new CheckListGoal(
                        parts[0],
                        parts[1],
                        int.Parse(parts[2]),
                        bool.Parse(parts[3]),
                        int.Parse(parts[5]),
                        int.Parse(parts[6]),
                        int.Parse(parts[7])));
                    break;
            }
        }
    }
    public void SaveGoals()
    {
        ObtainFileName("What is the filename for the goal file? ");
        using StreamWriter outputFile = new StreamWriter(_fileName);
        outputFile.WriteLine(_totalScore);

        foreach (BaseGoal goal in _goals)
        {
            outputFile.WriteLine(goal.GetFileSystemString());
        }
    }
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"\nYou have {_totalScore} points.\n");
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= _goals.Count)
        {
            int pointsEarned = _goals[index - 1].RecordEvent();
            _totalScore += pointsEarned;
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_totalScore} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
    private void ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        _fileName = Console.ReadLine();
    }
}