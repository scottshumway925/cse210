public class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display() {
        Console.WriteLine($"\nThis is {_name}'s resume: ");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs) {
            Console.WriteLine($"{job._jobTitle} ({job._company}) {job._startYear}-{job._endYear}");
        }
    }
}