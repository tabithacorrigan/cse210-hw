using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(5, "yellow");
        Console.WriteLine($"Area: {square1.GetArea()} Color: {square1.GetColor()}");

        Circle circle1 = new Circle(5, "green");
        Console.WriteLine($"Area: {circle1.GetArea()} Color: {circle1.GetColor()}");

        Rectangle rectangle1 = new Rectangle(2, 7, "blue");
        Console.WriteLine($"Area: {rectangle1.GetArea()} Color : {rectangle1.GetColor()}");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square(10, "purple"));
        shapes.Add(new Circle(2, "orange"));
        shapes.Add(new Rectangle(12, 5, "red"));

        Console.WriteLine("\nListed Shapes");
        foreach (Shape shape in shapes){
            Console.WriteLine($"Area: {shape.GetArea()} Color: {shape.GetColor()}");
        }
    }
}