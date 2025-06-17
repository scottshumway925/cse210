class PoliceMan : Person
{
    private string _weapons;
    private double _hourlyWage;
    private int _hoursWorked;

    public PoliceMan(string firstname, string lastname, int age, string weapons, int hours, double hourlyWage) : base(firstname, lastname, age)
    {
        _weapons = weapons;
        _hourlyWage = hourlyWage;
        _hoursWorked = hours;
    }

    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    }

    public override string GetPersonInformation()
    {
        return $"Weapons: {_weapons} :: {base.GetPersonInformation()}";
    }

    public override double GetSalary()
    {
        if (_hoursWorked > 40)
        {
            return 40 * _hourlyWage + ((_hoursWorked - 40) * (_hourlyWage * 1.5));
        }
        else
        {
            return _hoursWorked * _hourlyWage;
        }
    }
}