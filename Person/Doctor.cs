class Doctor : Person
{
    private string _tools;
    private double _salary;
    public Doctor(string firstname, string lastname, int age, string tools, double salary) : base(firstname, lastname, age)
    {
        _tools = tools;
        _salary = salary;
    }

    public string GetDoctorInformation()
    {
        return $"Tools: {_tools} :: {GetPersonInformation()}";
    }

    public override string GetPersonInformation()
    {
        return $"Weapons: {_tools} :: {base.GetPersonInformation()}";
    }

    public override double GetSalary()
    {
        return _salary;
    }
}