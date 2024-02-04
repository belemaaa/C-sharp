namespace CSHARPTUTORIAL;
using System.Collections.Generic;


public class CustomerList
{
    public int id { get; set; }
    public string name { get; set; }
    public int salary { get; set; }
}
public class Lists
{
    public static void ListsOps()
    {
        CustomerList customer1 = new CustomerList()
        {
            id = 119,
            name = "John",
            salary = 500
        };

        CustomerList customer2 = new CustomerList()
        {
            id = 120,
            name = "David",
            salary = 1000
        };
    }


}
