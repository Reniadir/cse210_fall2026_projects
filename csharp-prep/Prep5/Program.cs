using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int num = PromptUserNumber();

        PromtUserBirthYear(out int birthYear);

        int sqrNum = SquareNumber(num);

        DisplayResult(name, sqrNum, birthYear);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static void PromtUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int num)
    {
        int sqrNum = num *num;
        return sqrNum;
    }
    static void DisplayResult(string name, int sqrNum, int birthYear)
    {
        Console.WriteLine($"{name}, the square if your number is {sqrNum}.");
        Console.WriteLine($"{name}, you will turn {2026-birthYear} this year.");
    }
}