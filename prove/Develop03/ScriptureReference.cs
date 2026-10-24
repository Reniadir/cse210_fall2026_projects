using System.ComponentModel.DataAnnotations;

class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;
    }
    public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public void DisplayScriptureReference()
    {
        Console.Write(GetScriptureReference());
    }
    public string GetScriptureReference()
    {
        if (_endVerse == 0)
        {
            return $"{_bookName} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_bookName} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}