using System;

class Program
{
    static void Main(string[] args)
    {
        Journal executionJournal = new Journal();
        Menu MyMenu = new Menu();
        int response = 0;
        string file = "";
        
        Console.WriteLine("Welcome to the Journal Program!");

        while (response != 5)
        {
            response = MyMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                    Console.WriteLine("New Entry: ");
                    JournalEntry entry = new JournalEntry();
                    entry.CreateJournalEntry();
                    executionJournal.AddEntry(entry);
                    break;
                case 2:
                    Console.WriteLine("Journal:");
                    executionJournal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("Save to: ");
                    file = Console.ReadLine();
                    executionJournal.SaveToFile(file);
                    break;
                case 4:
                    Console.WriteLine("Read from: ");
                    file = Console.ReadLine();
                    executionJournal.ReadFromFile(file);
                    break;

            }
        }
    }
}