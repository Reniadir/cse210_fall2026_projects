using System.ComponentModel;
using System.Dynamic;

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
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"{_desc}");
        Console.WriteLine("How long would you like to do this activity?");
        string userInput = Console.ReadLine();
        int newDuration = int.Parse(userInput);
        SetTime(newDuration);
        Countdown("Begin in", 5);
    }
    public void EndMessage()
    {
        Spinner("Thanks for participating", 5);
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
        Console.Write($"{message} ");
        string spinnerAnimation = "-\\|/";
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(count);
        while (DateTime.Now < endTime)
        {
            Console.Write($"{spinnerAnimation[index++ % spinnerAnimation.Length]}");
            Console.Write("\b");
            Thread.Sleep(300);
        }
        Console.CursorVisible = true;
    }
    public int GetTime()
    {
        return _time;
    }
    public void SetTime(int newDuration)
    {
        _time = newDuration;
    }
}