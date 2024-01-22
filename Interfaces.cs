namespace CSHARPTUTORIAL;


// interfaces are public by default
interface ICustomers
{
    void InterfaceMethod();
}

interface ICustomers2
{
    void InterfaceMethod();
}

class Customers : ICustomers, ICustomers2
{
    // explicit interface implementation
    public void InterfaceMethod()
    {
        Console.WriteLine("Interface 1");
    }

    void ICustomers2.InterfaceMethod()
    {
        Console.WriteLine("Interface 2");
    }
}

// abstract class implememtation
abstract class AS
{
    public abstract void Print();
}

class ASImplementation : AS
{
    public override void Print()
    {
        Console.WriteLine("Overriding an abstract class method");
    }
}


public class Interfaces
{
    public static void InterfaceOps()
    {
        ICustomers2 C1 = new Customers();
        C1.InterfaceMethod();

        AS Customer = new ASImplementation();
        Customer.Print();
    }
}