using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string name = AcquireName();
        int number = AcquireNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(squaredNumber, name);
        

        static void WelcomeMessage() {
            Console.WriteLine ("Welcome to the Program!");
        }

        static string AcquireName() {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int AcquireNumber() {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number) {
            int squaredNumber = number * number;
            return squaredNumber;
        }

        static void DisplayResult(int squaredNumber, string name) {
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        }
    }
}