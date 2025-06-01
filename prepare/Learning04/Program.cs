using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("John", "Derivitives");
        Console.WriteLine(a.GetSummary());

        MathAssignment a1 = new MathAssignment("John", "Math", "7.3", "8-19");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine(a1.GetHomeworkList());

        WritingAssignment a2 = new WritingAssignment("John", "History", "George Washingtons Ascent");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetWritingInformation());
    }
}