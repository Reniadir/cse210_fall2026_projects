class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goals goalsManager = new Goals();
        
        bool running = true;
        while (running)
        {
            goalsManager.DisplayScore();
            int choice = menu.DisplayMenu();
        
            switch (choice)
            {
                case 1:
                    int goalTypeChoice = menu.CreateGoalMenu();
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine() ?? string.Empty;
        
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine() ?? string.Empty;
        
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine() ?? "0");
        
                    if (goalTypeChoice == 1)
                    {
                        goalsManager.AddGoal(new SimpleGoal(name, description, points, false));
                    }
                    else if (goalTypeChoice == 2)
                    {
                        goalsManager.AddGoal(new EternalGoal(name, description, points, false, 0));
                    }
                    else if (goalTypeChoice == 3)
                    {
                        CheckListGoal checklist = new CheckListGoal(name, description, points, false, 0, 1, 0);
                        checklist.SetMaxGoal();
                        checklist.SetBonusPoints();
                        goalsManager.AddGoal(checklist);
                    }
                    break;
        
                case 2:
                    goalsManager.DisplayGoals();
                    break;
        
                case 3:
                    goalsManager.SaveGoals();
                    break;
        
                case 4:
                    goalsManager.LoadGoals();
                    break;
        
                case 5:
                    goalsManager.RecordEvent();
                    break;
        
                case 6:
                    running = false;
                    break;
        
                default:
                    Console.WriteLine("Please enter a valid option (1–6).");
                    break;
            }
        }
    }
}