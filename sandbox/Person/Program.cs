class Program
{
    static void Main()
    {
        Police myPolice = new Police("Steven", "Sharp", 33, 205, "Sword");
        Console.WriteLine(myPolice.GetPersonInfo());

        Doctor myDoctor = new Doctor("Bill", "Cipher", 55, 150, "Knife");
        Console.WriteLine(myDoctor.GetPersonInfo());

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPolice);
        myPeople.Add(myDoctor);

        foreach(Person person in myPeople)
        {
            Console.WriteLine(person.GetPersonInfo());
        }

    }
}