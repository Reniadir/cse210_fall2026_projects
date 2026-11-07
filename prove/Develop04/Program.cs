using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Breathing newBreath = new Breathing(20, "Welcome to the Breathing Activity!", "We will go thru a process of breathing in and out, follow a long as we go.");
        Reflection newReflection = new Reflection(20, "Welcome to the Reflection Activity!", "We will go thru a process of reflecting, follow along as we go.");

        string userInput = "0";
        while (userInput != "4")
        {
            menu.DisplayMenu();
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                newBreath.RunActivity();
            }
            else if(userInput == "2")
            {
                newReflection.RunActivity();
            }
            else if(userInput == "3")
            {
                
            }
            else if(userInput == "4")
            {
                break;
            }
            else
            {
                Console.CursorVisible = false;
                Console.WriteLine("Invalid Input");
                Thread.Sleep(1000);
                Console.Clear();
                Console.CursorVisible = true;
            }
            Console.Clear();

        }        
    }
}