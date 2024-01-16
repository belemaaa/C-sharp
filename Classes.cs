using System.Net.NetworkInformation;

namespace CSHARPTUTORIAL;


class Customer
{
    string _firstname;
    string _lastname;

    // default constructor parameters
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

public class Classes
{
    public static void ClassesLesson()
    {
        Customer customer1 = new Customer();
        customer1.PrintName();

        Circle circle1 = new Circle(23);
        double area = circle1.CalculateArea();

        Console.WriteLine($"Area: {area} ");
    }
}
