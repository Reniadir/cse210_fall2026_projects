using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Breathing newBreath = new Breathing(
            20, 
            "Welcome to the Breathing Activity!", 
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Reflection newReflection = new Reflection(
            20, 
            "Welcome to the Reflection Activity!", 
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Listing newListing = new Listing(
            20,
            "Welcome to the Breathing Activity!",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        );
        Console.Clear();
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
                newListing.RunActivity();
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