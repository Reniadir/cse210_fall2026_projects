class Listing : Activities
{
    private List<string> _prompts = [
            "Who are people that you appreciate?", 
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];

    public Listing(int time, string name, string desc)
    : base(time, name, desc) {}

    public void RunActivity()
    {
        Console.Clear();
        StartMessage();
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(GetTime());
        Random random = new Random();
        int choosePropmt = random.Next(0, 3);
        int countList = 0;
        Console.WriteLine(_prompts[choosePropmt]);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            countList++;
        }
        Console.Clear();
        Console.WriteLine($"You listed {countList} things!"); 
        Thread.Sleep(2000);
        EndMessage();
    }
}