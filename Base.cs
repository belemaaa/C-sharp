using System.Text;

namespace CSHARPTUTORIAL;


public class Base
{
    public static void BaseConversion()
    {
        Console.WriteLine("Welcome to the Base Conversion Calculator");

    start:
        Console.WriteLine("\nWould you wish to convert from \n1. Base 10 to base 2 \n2. Base 2 to base 10 \n3. Base 10 to base 16 \n4. Base 16 to base 10");
        bool tryInput = int.TryParse(Console.ReadLine(), out int input);

        if (!tryInput || input < 1 || input > 4)
        {
            Console.WriteLine("Please input a valid value");
            goto start;
        }

        else
        {
            while (tryInput == true && input >= 1 && input <= 4)
            {
                bool success = false;
                string baseValue = "";

                switch (input)
                {
                    case 1:
                        Console.WriteLine("To convert from base 10 to base 2, input a number in base 10");
                        baseValue = Console.ReadLine();

                        success = IsDecimalNumber(baseValue);
                        if (success)
                        {
                            Console.WriteLine($"Selected option: Base 10 to 2");
                            Console.WriteLine($"Value entered: {baseValue}");
                            Console.WriteLine("Calculation result: ");
                            Console.WriteLine("------------------");

                            Console.WriteLine($"{baseValue} to base 2 = {BaseTenToTwoConverter(baseValue)}");
                        }
                        else
                        {
                            Console.WriteLine("Value entered cannot be read.");
                            goto start;
                        }

                        break;

                    case 2:
                        Console.WriteLine("To convert from base 2 to base 10, input a number in base 2");
                        baseValue = Console.ReadLine();

                        success = IsBinaryNumber(baseValue);
                        if (success)
                        {
                            Console.WriteLine($"Selected option: Base 2 to 10");
                            Console.WriteLine($"Value entered: {baseValue}");
                            Console.WriteLine("Calculation result: ");
                            Console.WriteLine("------------------");

                            Console.WriteLine($"{baseValue} to base 10 = {BaseTwoToTenConverter(baseValue)}");
                        }
                        else
                        {
                            Console.WriteLine("Value entered cannot be read.");
                            goto start;
                        }
                        break;

                    case 3:
                        Console.WriteLine("To convert from base 10 to base 16, input a number in base 10");
                        baseValue = Console.ReadLine();

                        success = IsDecimalNumber(baseValue);
                        if (success)
                        {
                            Console.WriteLine($"Selected option: Base 10 to 16");
                            Console.WriteLine($"Value entered: {baseValue}");
                            Console.WriteLine("Calculation result: ");
                            Console.WriteLine("------------------");

                            Console.WriteLine($"{baseValue} to base 10 = {BaseTenToSixteenConverter(baseValue)}");
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

    // character input validations
    public static bool IsBinaryNumber(string number)
    {
        int n = 0;
        if (string.IsNullOrEmpty(number))
            return false;

        foreach (char num in number)
        {
            bool isANumber = int.TryParse(num.ToString(), out n);
            if (isANumber == false)
                return false;
            if (n > 1)
                return false;
        }
        return true;
    }

    public static bool IsDecimalNumber(string number)
    {
        int n = 0;
        if (string.IsNullOrEmpty(number))
            return false;

        foreach (char num in number)
        {
            bool isANumber = int.TryParse(num.ToString(), out n);
            if (isANumber == false)
                return false;
        }
        return true;
    }

    public static bool IsHexadecimalNumber(string number)
    {
        if (string.IsNullOrEmpty(number))
            return false;

        foreach (char ch in number)
        {
            if (!(char.IsDigit(ch) || (ch >= 'a' && ch <= 'f') || (ch >= 'A' && ch <= 'F')))
                return false;
        }
        return true;
    }

    // base converters
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
            int convertedValue = (int)Math.Pow(2, i) * int.Parse(value[j].ToString());

            result += convertedValue;
            j++;
        }
        return result;
    }

    public static string BaseTenToSixteenConverter(string value)
    {
        int convertedValue = int.Parse(value.ToString());
        string result = "";

        while (convertedValue > 0)
        {
            int modulus = convertedValue % 16;
            if (modulus < 10)
            {
                result = modulus.ToString() + result;
            }
            else
            {
                switch (modulus)
                {
                    case 10:
                        result = "A" + result;
                        break;
                    case 11:
                        result = "B" + result;
                        break;
                    case 12:
                        result = "C" + result;
                        break;
                    case 13:
                        result = "D" + result;
                        break;
                    case 14:
                        result = "E" + result;
                        break;
                    case 15:
                        result = "F" + result;
                        break;
                }
            }
            convertedValue /= 16;
        }
        return result;
    }

    // public static string BaseTenToSixteenConverter(string value)
    // {
    //     string result = "";
    //     int j = 0;
    //     int a = 10;
    //     int b = 11;
    //     int c = 12;
    //     int d = 13;
    //     int e = 14;
    //     int f = 15;

    //     foreach (char ch in value)
    //     {
    //         if (char.IsDigit(ch)) 
    //             return ch.ToString();

    //         if (ch == 'a')
    //     }

    //     while (value.Length > 0)
    //     {

    //     }
    //     return result;
    // }

}

