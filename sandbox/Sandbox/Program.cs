using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Console.Write("Please Input Your First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please Input Your Last Name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"My name is {lastName}, {firstName} {lastName}");
    }
}