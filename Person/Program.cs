class Program
{
    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Bubba", "Bob", 53);
        // Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Cooper", "Slick", 34, "Club", 43, 20);
        // Console.WriteLine(myPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("Payne", "Bob", 56, "Scalpal", 200000);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>() { myDoctor, myPoliceMan };

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }

    private static void DisplayPersonInformation(Person person)
    {
        Console.Write($"\n{person.GetPersonInformation()} ");
        Console.WriteLine($"Salary: {person.GetSalary()}");
    }

}