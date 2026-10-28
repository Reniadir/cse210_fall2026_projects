using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Logan Smedley", "Calculus");
        Console.WriteLine(myAssignment.GetSummary());

        Console.WriteLine();
        MathAssignment myMath = new MathAssignment("Logan Smedley", "Calculus", "Derivatives", "1-8");
        Console.WriteLine(myMath.GetSummary());
        Console.WriteLine(myMath.GetHomeworkList());

        Console.WriteLine();
        WritingAssignment myWriting = new WritingAssignment("Logan Smedley", "Writing", "War and Peace");
        Console.WriteLine(myWriting.GetSummary());
        Console.WriteLine(myWriting.GetWritingInfo());
    }
}