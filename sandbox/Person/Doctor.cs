class Doctor : Person
{    
    private string _tools;
    private double _salary = 200000;

    public Doctor(string firstName, string lastName, int age, double weight, string tool)
    : base (firstName, lastName, age, weight)
    {
        _tools = tool;
    }
    public override string GetPersonInfo()
    {
        return $"Doctor Tools: {_tools}, {base.GetPersonInfo()}";
    }
    public override double GetSalary()
    {
        return _salary;
    }
}