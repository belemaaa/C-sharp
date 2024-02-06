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

        CustomerList customer3 = new CustomerList()
        {
            id = 121,
            name = "James",
            salary = 1000
        };

        List<CustomerList> customers = new List<CustomerList>(2);
        customers.Add(customer1);
        customers.Add(customer2);
        customers.Add(customer3);

        CustomerList c = customers[0];
        Console.WriteLine($"ID: {c.id}, Name: {c.name}, salary: {c.salary}");
    }


}
