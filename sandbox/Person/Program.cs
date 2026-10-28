class Program
{
    static void Main()
    {
        Person myPerson = new Person("Bob", "Builder", 87, 238);
        Console.WriteLine(myPerson.GetPersonInfo());

        Police myPolice = new Police("Steven", "Sharp", 33, 205, "Sword");
        Console.WriteLine(myPolice.GetPoliceInfo());

        Doctor myDoctor = new Doctor("Bill", "Cipher", 55, 150, "Knife");
        Console.WriteLine(myDoctor.GetDoctorInfo());

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myPolice);
        myPeople.Add(myDoctor);

        foreach(Person person in myPeople)
        {
            Console.WriteLine(person.GetPersonInfo());
        }

    }
}