using System;

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

        Cylidner myCylinder = new Cylidner();
        myCylinder.SetCircle(myCircle);
        myCylinder.SetHeight(10);
        Console.WriteLine($"{myCylinder.GetVolume()}");

    }
}