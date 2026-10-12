using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Fraction num1 = new Fraction();
        Console.WriteLine(num1.GetFractionString());
        Console.WriteLine(num1.GetDecimalValue());

        Fraction num2 = new Fraction(5);
        Console.WriteLine(num2.GetFractionString());
        Console.WriteLine(num2.GetDecimalValue());

        Fraction num3 = new Fraction(3,4);
        Console.WriteLine(num3.GetFractionString());
        Console.WriteLine(num3.GetDecimalValue());

        Fraction num4 = new Fraction(1,3);
        Console.WriteLine(num4.GetFractionString());
        Console.WriteLine(num4.GetDecimalValue());

        Console.WriteLine();
        Random rand = new Random();
        Fraction num5 = new Fraction();
        for (int i = 0; i <20; i++)
        {
            int top = rand.Next(1,11);
            int bot = rand.Next(1,11);
            num5.SetTop(top);
            num5.SetBot(bot);
            string frac = num5.GetFractionString();
            double dec = num5.GetDecimalValue();
            Console.WriteLine($"Fraction {i}: String: {frac} Number: {dec}");
        }
    }
}