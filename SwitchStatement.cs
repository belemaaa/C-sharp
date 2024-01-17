namespace CSHARPTUTORIAL;

public class SwitchStatement
{
    public static void SwitchOps()
    {
        Console.WriteLine("Welcome to our coffee shop");

    Start:
        Console.WriteLine("What order are you taking? \n 1: small coffee - 3$, \n 2: big coffee - 10$");
        bool success = int.TryParse(Console.ReadLine(), out int userChoice);

        int price = 0;
        switch (userChoice)
        {
            case 1:
                Console.WriteLine($"Your total is {price += 3} $");
                break;

            case 2:
                Console.WriteLine($"Your total is {price += 10} $");
                break;

            default:
                Console.WriteLine("Invalid input");
                goto Start;
        }
    Decide:
        Console.WriteLine("Do you want to buy another coffee? \n yes \n no");
        string? input = Console.ReadLine();

        switch (input?.ToLower())
        {
            case "yes":
                goto Start;

            case "no":
                break;

            default:
                Console.WriteLine("Invalid input");
                goto Decide;
        }
    }
}
