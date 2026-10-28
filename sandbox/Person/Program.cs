class Program
{
    static void Main()
    {
        Person bob = new Person("Bob", "Builder", 87, 238);
        bob.DisplayPersonInfo();

        Police steven = new Police("Steven", "Sharp", 33, 205, "Sword");
        steven.DisplayPersonInfo();
    }
}