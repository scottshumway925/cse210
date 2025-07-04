using System.Security.Cryptography;

abstract class Person
{
    private string _lastname;
    private string _firstname;
    private int _age;

    public Person()
    {
        _lastname = "";
        _firstname = "";
        _age = 0;
    }

    public Person(string lastname, string firstname, int age)
    {
        _lastname = lastname;
        _firstname = firstname;
        _age = age;
    }

    public virtual string GetPersonInformation()
    {
        return $"{_firstname} {_lastname}, Age: {_age}";
    }

    public abstract double GetSalary();
}