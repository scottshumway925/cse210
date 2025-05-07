using System;

class Program
{
    static void Main(string[] args) {
        
        // This code initializes two new job variables.
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2016;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "The Church of Jesus Christ of Latter Day Saints";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2023;
        job2._endYear = 2025;

        job1.Display();
        job2.Display();


        // Here is the code for the resume.
        Console.WriteLine($"\n\nThis is where the resume portion begins");

        Resume resume = new Resume();
        resume._name = "Scott Shumway";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        resume.Display();
    }
    
}