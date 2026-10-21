using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("bubba");
        myWord.Display();
        myWord.Hide();
        myWord.Display();

        Scripture myScripture = new Scripture("Moses", 1, 39, " For behold this is my work and my glory to bring to pass the immortatlity and eternal life of man.");
        Console.Clear();
        myScripture.ShowScripture();
    }
}