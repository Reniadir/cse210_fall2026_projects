using System.IO;
using System.Collections.Generic;

class Journal
{
    List<JournalEntry> _entries = new List<JournalEntry>();
    public void DisplayJournal()
    {
        foreach (JournalEntry entry in _entries)
        {
             entry.DisplayEntry();
        }
           
    }
    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (JournalEntry entry in _entries)
            {
                writer.WriteLine(entry.CreateFileSystemString());
            }
        }
    }
    public void ReadFromFile(string userFile)
    {
        _entries.Clear(); // Replaces any current entries per specifications
        string[] lines = File.ReadAllLines(userFile);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            JournalEntry newEntry= new JournalEntry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._response = parts[2];

            _entries.Add(newEntry);
        }
    }
}