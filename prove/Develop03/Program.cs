using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool continueProgram = true;
        string userInput = "";
        Scripture myScripture = new Scripture("Moses", 1, 39, " For behold this is my work and my glory to bring to pass the immortatlity and eternal life of man.");
        Console.Clear();
        myScripture.ShowScripture();

        while (continueProgram == true)
        {
            userInput = Console.ReadLine();
            if (userInput == "exit")
            {
                break;
            }
            else
            {
                 Console.Clear();
                myScripture.HideSomeWords();
                myScripture.ShowScripture();
            }
        }
    }
}