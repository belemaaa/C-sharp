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

        //lists are strongly typed. You can only append a customer object or a related object (through inheritance) to this list
        List<CustomerList> customers = new List<CustomerList>();
        customers.Add(customer1);
        customers.Add(customer2);
        customers.Add(customer3);
        customers.Insert(0, customer3);

        CustomerList existing_customer = customers.Find(cust => cust.id == 121);
        Console.WriteLine($"id: {existing_customer.id}");

        List<CustomerList> customerlist = customers.FindAll(cust => cust.salary > 100);
        foreach (CustomerList c in customerlist)
        {
            Console.WriteLine($"id: {c.id}");
        }
    }


}
