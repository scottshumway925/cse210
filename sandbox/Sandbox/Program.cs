using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // Console.Write("Please Input Your First Name: ");
        // string firstName = Console.ReadLine();
        // Console.Write("Please Input Your Last Name: ");
        // string lastName = Console.ReadLine();
        // Console.WriteLine($"My name is {lastName}, {firstName} {lastName}");

        // Here is a fun comment.

        // This is a second comment.

        List<int> myNumbers = new List<int>();
        myNumbers.Add(1);
        myNumbers.Add(72);
        myNumbers.Add(37);

        foreach (int i in myNumbers) {
            Console.WriteLine(i);
        }



    }
}