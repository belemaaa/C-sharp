using System.Text;

namespace CSHARPTUTORIAL;


public class Base
{
    public static void BaseConversion()
    {
        Console.WriteLine("Welcome to the Base Conversion Calculator");

    start:
        Console.WriteLine("\nWould you wish to convert from \n1. Base 10 to base 2 \n2. Base 2 to base 10");
        bool tryInput = int.TryParse(Console.ReadLine(), out int input);

        if (!tryInput || input < 1 || input > 2)
        {
            Console.WriteLine("Please input a valid value");
            goto start;
        }

        else
        {
            while (tryInput == true && input == 1 || input == 2)
            {
                switch (input)
                {
                    case 1:
                        Console.WriteLine("To convert from base 10 to base 2, input a number in base 10");
                        string? BaseTenValue = Console.ReadLine();

                        bool successDecimal = IsDecimalNumber(BaseTenValue);
                        if (successDecimal)
                        {
                            Console.WriteLine($"Selected option: Base 10 to 2");
                            Console.WriteLine($"Value entered: {BaseTenValue}");
                            Console.WriteLine("Calculation result: ");
                            Console.WriteLine("------------------");

                            Console.WriteLine($"{BaseTenValue} to base 2 = {BaseTenToTwoConverter(BaseTenValue)}");
                        }
                        else
                        {
                            Console.WriteLine("Value entered cannot be read.");
                            goto start;
                        }

                        break;

                    case 2:
                        Console.WriteLine("To convert from base 2 to base 10, input a number in base 2");
                        string? BaseTwoValue = Console.ReadLine();

                        bool successBinary = IsBinaryNumber(BaseTwoValue);
                        if (successBinary)
                        {
                            Console.WriteLine($"Selected option: Base 2 to 10");
                            Console.WriteLine($"Value entered: {BaseTwoValue}");
                            Console.WriteLine("Calculation result: ");
                            Console.WriteLine("------------------");

                            Console.WriteLine($"{BaseTwoValue} to base 10 = {BaseTwoToTenConverter(BaseTwoValue)}");
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
                Console.WriteLine("\nDo you want to perform another conversion? Enter Yes or No");
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

    public static int BaseTwoToTenConverter(string value)
    {
        int result = 0;
        int j = 0;

        for (int i = value.Length - 1; i >= 0; i--)
        {
            int convertedValue = (int)Math.Pow(2, i) * int.Parse(value[j].ToString()) ;

            result += convertedValue;
            j++;
        }
        return result;
    }
}

