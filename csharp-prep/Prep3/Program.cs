using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number;
        int guess;
        int guessCount = 0;
        string playVar = "y";
        bool playing = true;
        
        while (playing == true) {
            guessCount = 0;
            number = randomGenerator.Next(1,101);

            do {
                Console.Write($"What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess > number) {
                    Console.WriteLine("Lower");
                } else if (guess < number) {
                    Console.WriteLine("Higher");
                } else {
                    Console.WriteLine("Correct!");
                }
            } while (guess != number);

            Console.WriteLine($"You guessed {guessCount} times.");
            Console.Write("Would you like to play again? (y/n) ");
            playVar = Console.ReadLine();
            if (playVar == "n") {
                playing = false;
            }
        }
        
    }
}