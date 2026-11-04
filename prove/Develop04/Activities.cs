using System.ComponentModel;

class Activities
{
    private int _time;
    private string _name;
    private string _desc;

    public Activities(int time, string name, string desc)
    {
        _time = time;
        _name = name;
        _desc = desc;
    }
    public void Countdown(string message, int count)
    {
        Console.CursorVisible = false;
        for (int i=count; i>=1; i--)
        {
            Console.Clear();
            Console.Write($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }
    public void Spinner(string message, int count)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message}");
        for (int i=0; i<count; i++)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }
}