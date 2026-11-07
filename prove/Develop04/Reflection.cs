class Reflection : Activities
{
    private List<string> _prompts = [
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless."
        ];
    private List<string> _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];

    public Reflection(int time, string name, string desc)
    : base(time, name, desc) {}

    public void RunActivity()
    {
        Console.Clear();
        StartMessage();
        Console.CursorVisible = false;
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(GetTime());
        Random random = new Random();
        int choosePropmt = random.Next(0, 3);
        Console.WriteLine(_prompts[choosePropmt]);
        while (DateTime.Now < endTime)
        {
            int chooseQuestion = random.Next(0, 8);
            Console.WriteLine(_questions[chooseQuestion]);
            Thread.Sleep(10000);
        }
        Console.Clear();
        EndMessage();
    }
}