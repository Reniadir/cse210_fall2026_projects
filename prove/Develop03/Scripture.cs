class Scripture
{
    List<Word> _words;
    // TODO: Add Scripture Refernce

    public Scripture(string BookName, int chapter, int verse, string text)
    {
        // TODO Add Scripture Refernce
        _words = ConvertToWords(text);
    }
    public Scripture(string BookName, int chapter, int startVerse, int endVerse, string text)
    {
        // TODO Add Scripture Refernce
        _words = ConvertToWords(text);
    }
    public void HideSomeWords()
    {
        int numWords = _words.Count;
        Random random = new Random();
        for ( int i = 0; i< 1; i++)
        {
            int hideIndex = random.Next(1, numWords);
            _words[hideIndex].Hide();
        }
    }
    public void ShowScripture()
    {
        foreach (Word word in _words)
        {
            word.Display();
        }
    }
    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }
        return tempWords;
    }
}