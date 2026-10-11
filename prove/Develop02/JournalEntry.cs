using System.Runtime.InteropServices;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    Random random = new Random();
    List<String> _promptList = ["How was your day? ", 
                                "What was the best part of today? ", 
                                "If today was a fruit what fruit would it be?", 
                                "What did you do today? ", 
                                "How did you survive the day? ",
                                "What brought the spirit into your day? ",
                                "If you had to rate this day on a scale of 1-10 what would it be and why? ",
                                "What did you eat for breakfast? "];

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} ");
        Console.Write($"{_prompt} ");
        Console.WriteLine($"{_response}");
    }
    public string RandomPrompt()
    {
        string newPrompt = _promptList[random.Next(1,8)];
        return newPrompt;
    }

    public void CreateJournalEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date = dateText;
        _prompt = RandomPrompt();
        
        Console.Write($"{_prompt}");
        _response = Console.ReadLine();
    }
    public string CreateFileSystemString()
    {
        return $"{_date}~{_prompt}~{_response}";
    }
}