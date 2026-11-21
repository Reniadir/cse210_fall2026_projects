using System.ComponentModel.DataAnnotations;

public class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the Menu: ");
        int userInput = int.Parse(Console.ReadLine());
        return userInput;
    }
    public int CreateGoalMenu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int userInput = int.Parse(Console.ReadLine());
        return userInput;
    }
}