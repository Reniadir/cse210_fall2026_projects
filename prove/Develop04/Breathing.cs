class Breathing : Activities
{
    public Breathing(int time, string name, string desc)
    : base(time, name, desc) {}

    public void RunActivity()
    {
        Console.Clear();
        StartMessage();
        Console.CursorVisible = false;
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(GetTime());
        while (DateTime.Now < endTime)
        {
            BreathIn();
            BreathOut();
        }
        Console.Clear();
        EndMessage();

    }
    public void BreathIn()
    {
        Countdown("Breathe in", 4);
    }
    public void BreathOut()
    {
        Countdown("Breathe out", 4);
    }
}