using System.Text;

namespace CSHARPTUTORIAL;


public class Base
{
    public static void BaseConversion()
    {
        Console.WriteLine("Welcome to the Base Conversion Calculator");

    start:
        Console.WriteLine("Would you wish to convert from \n1. Base 10 to base 2 \n2. Base 2 to base 10");
        bool tryInput = int.TryParse(Console.ReadLine(), out int input);

        if (tryInput == false)
        {
            Console.WriteLine("Invalid input");
            goto start;
        }

        while (tryInput == true)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("To convert from base 10 to base 2, input a number in base 10");
                    string? BaseTenValue = Console.ReadLine();

                    Console.WriteLine($"Selected option: Base 10 to 2");
                    Console.WriteLine($"Value emtered: {BaseTenValue}");
                    Console.WriteLine("Calculation result: ");
                    Console.WriteLine("------------------");

                    Console.WriteLine("test");
                    Console.WriteLine($"{BaseTenValue} to base 2 = {BaseTenToTwoConverter(BaseTenValue)}");
                    break;

                case 2:
                    Console.WriteLine("To convert from base 2 to base 10, input a number in base 2");
                    string? BaseTwoValue = Console.ReadLine();

                    Console.WriteLine($"Selected option: Base 2 to 10");
                    Console.WriteLine($"Value emtered: {BaseTwoValue}");
                    Console.WriteLine("Calculation result: ");
                    Console.WriteLine("------------------");

                    Console.WriteLine($"{BaseTwoValue} to base 10 = {BaseTenToTwoConverter(BaseTwoValue)}");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        Restart:
            Console.WriteLine("Do you want to perform another conversion? Enter Yes or No");
            string? option = Console.ReadLine();

            if (option == "yes".ToLower())
            {
                goto start;
            }
            else if (option == "no".ToLower())
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                goto Restart;
            }
        }
    }

    public static StringBuilder BaseTenToTwoConverter(string value)
    {
        StringBuilder result = new StringBuilder();
        int convertedValue = int.Parse(value.ToString());

        while (convertedValue > 0){
            int modulus = convertedValue % 2;

            result.Insert(0, modulus);  
            convertedValue /= 2;
        }
        return result;
    }

    public static StringBuilder BaseTwoToTenConverter(string value)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < value.Length; i++)
        {
            int convertedValue = (int)Math.Pow((value[i] * 2), i);

            result.Append(convertedValue);
        }
        return result;
    }
}

