using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float userInput;
        float sum = 0;
        float average;
        float largestNumber = 0;
        
        do {
            Console.Write("What number would you like to add to the list? ");
            userInput = float.Parse(Console.ReadLine());
            if (userInput != 0) {
                numbers.Add(userInput);
            }
        } while (userInput != 0);

        foreach (float number in numbers) {
            sum += number;
            if (largestNumber < number) {
                largestNumber = number;
            }
        }

        average = sum / numbers.Count;


        Console.WriteLine($"Your total was: {sum}");
        Console.WriteLine($"Your average was: {average}");
        Console.WriteLine($"Your largest number was: {largestNumber}");
    }
}