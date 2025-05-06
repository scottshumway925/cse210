using System;

class Circle 
{
    private double _radius;

    public void SetRadius(double radius) {
        _radius = radius;
    }

    public double GetRadius() {
        return _radius;
    }

    public double GetArea() {
        return Math.PI * _radius * _radius;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Circle myCircle = new Circle();
        Circle myCircle2 = new Circle(); 

        myCircle.SetRadius(10);
        myCircle2.SetRadius(20);

        Console.WriteLine($"{myCircle.GetRadius()}");
        Console.WriteLine($"{myCircle2.GetRadius()}");
        
        Console.WriteLine($"{myCircle.GetArea()}");
        Console.WriteLine($"{myCircle2.GetArea()}");
    }
}