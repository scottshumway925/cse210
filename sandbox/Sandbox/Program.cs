using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This the the TestQuestionMarkOperator project");

        int? x = null;
        int? x2 = 3;
        string? name = null;

        int? y = x ?? 23;
        int? y2 = x2 ?? 23;
        Console.WriteLine(y);
        Console.WriteLine(y2);

        name ??= "Betty";
        Console.WriteLine(name);

        string? myName = null;
        int? length = myName?.Length;
        Console.WriteLine(length);

        int bettysAge = 23;
        int bobsAge = 25;
        string whoIsOlder = (bettysAge > bobsAge) ? "Betty is older" : "Bob is older";
        Console.WriteLine(whoIsOlder);
    }
}