using System.Net.NetworkInformation;

namespace CSHARPTUTORIAL;


class Customer
{
    string _firstname;
    string _lastname;

    public Customer()
        : this("No firstname provided", "No lastname provided") { }

    public Customer(string firstName, string lastName)
    {
        this._firstname = firstName;
        this._lastname = lastName;
    }

    public void PrintName()
    {
        Console.WriteLine($"Fullname: {this._firstname}, {this._lastname}");
    }

    ~Customer()
    {
        /*
        called by the garbage collector:
        used to clean up resources the class was holding onto during its lifetime
        */
    }
}

class Circle
{
    static double _PI = 3.141;
    int _Radius;

    public Circle(int Radius)
    {
        this._Radius = Radius;
    }

    public double CalculateArea()
    {
        return _PI * this._Radius * this._Radius;
    }
}


// illustrating inheritance
public class Employee
{
    public string? _FirstName;
    public string? _LastName;
    public string? _Email;

    public Employee()
    {
        Console.WriteLine("Parent class called");
    }

    public Employee(string FirstName, string lastName)
    {
        this._FirstName = FirstName;
        this._LastName = lastName;
    }

    public virtual void PrintFullName()
    {
        Console.WriteLine(this._FirstName + " " + this._LastName);
    }
}

public class FullTimeEmployee : Employee
{
    int YearlySal;
    public override void PrintFullName()
    {
        Console.WriteLine(this._FirstName + " " + this._LastName + this.YearlySal + " - Fulltime");
    }

}

public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(this._FirstName + " " + this._LastName + " - Contractor");
    }
}

public class Classes
{
    public static void ClassesLesson()
    {
        Employee PTE = new PartTimeEmployee();
        PTE._FirstName = "John";
        PTE._LastName = "Doe";
        PTE.PrintFullName();

    }
}
