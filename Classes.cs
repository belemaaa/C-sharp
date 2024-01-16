namespace CSHARPTUTORIAL;


class Customer
{
    string _firstname;
    string _lastname;

    public Customer(string firstName, string lastName)
    {
        this._firstname = firstName;
        this._lastname = lastName;
    }

    public void PrintName()
    {
        Console.WriteLine($"Fullname: {this._firstname}, {this._lastname}");
    }

    /*
    called by the garbage collector:
    used to clean up resources the class was holding onto during its lifetime
    */
    ~Customer()
    {
        //clean up code
    }
}

public class Classes
{
    public static void ClassesLesson()
    {
        Customer customer1 = new Customer("Grace", "James");
        customer1.PrintName();
    }
}
