using System;

class Program
{
    static void Main(string[] args)
    {
        // Getting the grade percentage.
        Console.Write("What is your grade? ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letter;

        // Setting the letter grade.
        if (gradePercentage >= 90) {
            letter = "A";
        } else if (gradePercentage >= 80) {
            letter = "B";
        } else if (gradePercentage >= 70) {
            letter = "C";
        } else if (gradePercentage >= 60) {
            letter = "D";
        } else {
            letter = "F";
        }

        // Checking to see if the user passed.
        if (gradePercentage >= 70) {
            Console.WriteLine("Congratulations! You have passed the class!");
        } else {
            Console.WriteLine("You did not pass the class. You can do it next time for sure, though!");
        }

        // Displaying the users letter grade. 
        Console.WriteLine("Your letter grade was:" + letter);
    }
}