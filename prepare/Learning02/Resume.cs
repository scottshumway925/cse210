public class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display() {
        Console.WriteLine($"\nThis is {_name}'s resume: ");
        foreach (Job job in _jobs) {
            Console.WriteLine($"\nThe job title is: {job._jobTitle}");
            Console.WriteLine($"The company is: {job._company}");
            Console.WriteLine($"The start year is: {job._startYear}");
            Console.WriteLine($"The end year is: {job._endYear}");
        }
    }
}