public class Job {
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display() {
        Console.WriteLine($"\nThe job title is: {_jobTitle}");
        Console.WriteLine($"The company is: {_company}");
        Console.WriteLine($"The start year is: {_startYear}");
        Console.WriteLine($"The end year is: {_endYear}");
    }
}