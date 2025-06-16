using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle1 = new Rectangle("Pink", 2, 3);
        Rectangle rectangle2 = new Rectangle("Brown", 4, 5);
        Square square1 = new Square("Chartrouse", 7);
        Square square2 = new Square("Blue", 5);
        Circle circle1 = new Circle("Orange", 4);
        Circle circle2 = new Circle("White", 7);

        List<Shape> shapeList = new List<Shape>() {rectangle1, rectangle2, square1, square2, circle1, circle2};

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.ToString());
            Console.WriteLine($"Your shape color is: {shape.GetColor()} \nWith an area of: {shape.GetArea()}\n");
        }
    }
}