class Menu
{
    public int ProcessMenu()
    {
        int response = 0;

        while (response < 1 || response > 5)
        {
            Console.WriteLine("Create, Display, Save and read Journal Entry.");
            Console.WriteLine("1. Create new Journal Entry.");
            Console.WriteLine("2. Display Journal.");
            Console.WriteLine("3. Save Journal File.");
            Console.WriteLine("4. Read Journal from File.");
            Console.WriteLine("5. Quit.");


            response = int.Parse(Console.ReadLine());
        }
        return response;

    }
}