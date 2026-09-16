using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";
        string pass = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            pass = "Good job you passed the class!";
        }
        else
        {
            pass = "Sorry you didn't pass the class. Better luck next time!";
        }

        Console.WriteLine($"You got a {letter}. {pass}");

    }
}