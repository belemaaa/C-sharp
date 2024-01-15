using System.Runtime.CompilerServices;

namespace CSHARPTUTORIAL;

public class ShoppingList
{
    public static void ShoppingOps()
    {
        string[] shoppingItems = new string[5];
        shoppingItems[0] = "Glasses";
        shoppingItems[1] = "Trousers";
        shoppingItems[2] = "Phone";
        shoppingItems[3] = "Bags";
        shoppingItems[4] = "jewelry";

        int[] prices = new int[5];
        prices[0] = 500;
        prices[1] = 1000;
        prices[2] = 800;
        prices[3] = 900;
        prices[4] = 1200;

        Console.WriteLine("List of shopping items:");

        for (int i = 0; i < shoppingItems.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {shoppingItems[i]} - {prices[i]}");

        }

        Console.WriteLine("How many items do you wish to purchase? ");
        bool success = int.TryParse(Console.ReadLine(), out int input);

        int totalPrice = 0;
        if (success)
        {
            if (input > 0 && input <= shoppingItems.Length)
            {
                Console.WriteLine($"Input the IDs of the {input} items you wish to purhase:");

                int result = 0;
                for (int j = 0; j < input; j++)
                {
                    Console.Write($"ID {j + 1}:");
                    bool parsedIDs = int.TryParse(Console.ReadLine(), out result);
                    
                    if (parsedIDs == true){
                        totalPrice = totalPrice + prices[result - 1];
                    }  
                }
                Console.WriteLine($"Total price of items: {totalPrice}");
            }
            else{
                Console.WriteLine("Invalid input");
            }
        }

    }

}
