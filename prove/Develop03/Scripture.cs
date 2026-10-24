using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;

    public Scripture(string BookName, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(BookName, chapter, verse);
        _words = ConvertToWords(text);
    }
    public Scripture(string BookName, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(BookName, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }
    public void HideSomeWords()
    {
                int numWords = _words.Count;

         if (NumberOfHiddenWords() == numWords)
        {
            return;
        }

        Random random = new Random();
        int wordsToHide = 1; // Change this to hide more words per turn (e.g., 3)
        int hiddenThisTurn = 0;

        while (hiddenThisTurn < wordsToHide && NumberOfHiddenWords() < numWords)
        {
            int hideIndex = random.Next(0, numWords); // Start at 0 so the first word isn't skipped

            if (!_words[hideIndex].IsHidden())
            {
                _words[hideIndex].Hide();
                hiddenThisTurn++;
            }
        }

    }
    public void ShowScripture()
    {
        _reference.DisplayScriptureReference();
        foreach (Word word in _words)
        {
            word.Display();
        }
    }
    private int NumberOfHiddenWords()
    {
        int numHidden = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                numHidden++; 
            }
        }
        return numHidden;
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