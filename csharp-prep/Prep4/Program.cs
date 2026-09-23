using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        
        int new_number;
        List<int> numbers = new List<int>();
        int sum_numbers = 0;
        int largest = 0;
        int count = 0;
        decimal average;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            new_number = int.Parse(Console.ReadLine());
            numbers.Add(new_number);
        } while (new_number != 0);
        
        foreach (int number in numbers)
        {
            sum_numbers += number;
            count++;
            if (largest < number)
            {
                largest = number;
            }
        }
        average = (decimal)sum_numbers/count;

        Console.WriteLine($"The Sum is: {sum_numbers}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The Largest number is: {largest}");
    }
}