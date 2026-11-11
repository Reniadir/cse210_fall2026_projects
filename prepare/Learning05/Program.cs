using System;

class Program
{
    static void Main(string[] args)
    {
        Square squ = new Square(2);
        Rectangle rect = new Rectangle(2,4);
        Circle circ = new Circle(2);
        List<Shape> myShapes = new List<Shape>();
        myShapes.Add(squ);
        myShapes.Add(rect);
        myShapes.Add(circ);
        
        foreach (Shape currentShape in myShapes)
        {
            Console.WriteLine($"Color: {currentShape.GetColor()} Area: {currentShape.GetArea()}");
        }

    }
}