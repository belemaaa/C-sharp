namespace CSHARPTUTORIAL;

interface ICustomers
{
    void Print();
}

class Customers : ICustomers
{
    public void Print(){
        Console.WriteLine("Interface implementation");
    }
}

public class Interfaces
{
    public static void InterfaceOps()
    {
        Customers C1 = new Customers();
        C1.Print();
    }
}
