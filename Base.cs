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

        if (!tryInput || input < 0 || input > 2)
        {
            Console.WriteLine("Please input a valid value");
            goto start;
        }

        else
        {
            while (tryInput == true && input == 0 || input == 1)
            {
                switch (input)
                {
                    case 1:
                        Console.WriteLine("To convert from base 10 to base 2, input a number in base 10");
                        string? BaseTenValue = Console.ReadLine();

                        Console.WriteLine($"Selected option: Base 10 to 2");
                        Console.WriteLine($"Value entered: {BaseTenValue}");
                        Console.WriteLine("Calculation result: ");
                        Console.WriteLine("------------------");

                        Console.WriteLine($"{BaseTenValue} to base 2 = {BaseTenToTwoConverter(BaseTenValue)}");

                        break;

                    case 2:
                        Console.WriteLine("To convert from base 2 to base 10, input a number in base 2");
                        string? BaseTwoValue = Console.ReadLine();

                        bool yes = IsBinaryNumber(BaseTwoValue);
                        if (yes)
                        {
                            Console.WriteLine($"Selected option: Base 2 to 10");
                            Console.WriteLine($"Value entered: {BaseTwoValue}");
                            Console.WriteLine("Calculation result: ");
                            Console.WriteLine("------------------");

                            Console.WriteLine($"{BaseTwoValue} to base 10 = {BaseTenToTwoConverter(BaseTwoValue)}");
                        }
                        else
                        {
                            Console.WriteLine("Value entered cannot be read.");
                            goto start;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            Restart:
                Console.WriteLine("Do you want to perform another conversion? Enter Yes or No");
                string? option = Console.ReadLine();

                if (string.Equals(option, "yes", StringComparison.OrdinalIgnoreCase))
                {
                    goto start;
                }
                else if (string.Equals(option, "no", StringComparison.OrdinalIgnoreCase))
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
    }

    public static bool IsBinaryNumber(string number)
    {
        int n = 0;
        if (string.IsNullOrEmpty(number)) return false;
        foreach (char num in number)
        {
            bool isANumber = int.TryParse(num.ToString(), out n);
            if (isANumber == false) return false;
            if (n > 1) return false;
        }
        return true;
    }

    public static bool IsDecimalNumber(string number)
    {
        int n = 0;
        if (string.IsNullOrEmpty(number)) return false;
        foreach (char num in number)
        {
            bool isANumber = int.TryParse(num.ToString(), out n);
            if (isANumber == false) return false;
        }
        return true;
    }

    public static StringBuilder BaseTenToTwoConverter(string value)
    {
        StringBuilder result = new StringBuilder();
        int convertedValue = int.Parse(value.ToString());

        while (convertedValue > 0)
        {
            int modulus = convertedValue % 2;

            result.Insert(0, modulus);
            convertedValue /= 2;
        }
        return result;
    }

    public static StringBuilder BaseTwoToTenConverter(string value)
    {
        StringBuilder result = new StringBuilder();

        foreach (char digit in value)
        {

        }

        for (int i = 0; i < value.Length; i++)
        {
            int convertedValue = (int)Math.Pow((value[i] * 2), i);

            result.Append(convertedValue);
        }
        return result;
    }
}

