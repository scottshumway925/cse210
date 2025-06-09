class PoliceMan : Person
{
    private string _weapons;

    public PoliceMan(string firstname, string lastname, int age, string weapons) : base(firstname, lastname, age)
    {
        _weapons = weapons;
    }

    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    }
}