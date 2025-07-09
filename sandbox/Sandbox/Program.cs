using System;

class Program
{
    static void TestByRef(int x, ref string name)
    {
        x++;
        name += "Betty";

        Console.WriteLine($"In Test: {x}, {name}");
    }

    static void Main(string[] args)
    {
        int x = 10;
        string name = "Bob ";

        TestByRef(x, ref name);

        Console.WriteLine($"In Main: {x}, {name}");


    }
}