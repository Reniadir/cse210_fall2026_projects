class Doctor : Person
{
    private string _tools;

    public Doctor(string firstName, string lastName, int age, double weight, string tool)
    : base (firstName, lastName, age, weight)
    {
        _tools = tool;
    }
    public string GetDoctorInfo()
    {
        return $"Doctor: Tools: {_tools}, {GetPersonInfo()}";
    }
}