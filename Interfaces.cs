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

public class Interfaces
{
    public static void InterfaceOps()
    {
        ICustomers2 C1 = new Customers();
        C1.InterfaceMethod();
    }
}