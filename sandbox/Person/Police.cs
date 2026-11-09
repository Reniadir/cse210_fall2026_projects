class Police : Person
{
    private string _weapons;
    private double _salary = 50000;

    public Police(string firstName, string lastName, int age, double weight, string weapons)
    : base (firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }
    public override string GetPersonInfo()
    {
        return $"Police Weapons: {_weapons}, {base.GetPersonInfo()}";
    }
    public override double GetSalary()
    {
        return _salary;
    }
}