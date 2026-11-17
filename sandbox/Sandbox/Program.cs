using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        if (!Console.IsOutputRedirected)
        {
            Console.OutputEncoding = Encoding.UTF8;
        }

        string filePath = @"C:\Programming_for_classes\Programming\C#_Code\cse210_fall2026_projects\sandbox\Sandbox\Gladiatrix.txt";

        if (File.Exists(filePath))
        {
            foreach (string line in File.ReadLines(filePath, Encoding.UTF8))
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}   