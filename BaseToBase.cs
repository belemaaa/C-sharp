using System.Runtime.CompilerServices;
using System.Text;

namespace CSHARPTUTORIAL;

public class BaseToBase
{
    public static void BaseToBaseOps()
    {
        Console.WriteLine("Welcome to the Base Conversion Calculator");

    start:
        bool baseSuccess = false;

        Console.WriteLine("\nBase range is between 2-9 and 16");
        Console.WriteLine("What base do you want to convert from? ");
        baseSuccess = int.TryParse(Console.ReadLine(), out int initialBase);

        if (!baseSuccess || !(initialBase >= 2 || initialBase <= 9 || initialBase == 16))
        {
            Console.WriteLine("Please input a valid value");
            goto start;
        }
        else
        {
            Console.WriteLine("\nWhat base do you want to convert to? ");
            baseSuccess = int.TryParse(Console.ReadLine(), out int resultBase);

            if (!baseSuccess || !(resultBase >= 2 || resultBase <= 9 || resultBase == 16))
            {
                Console.WriteLine("Please input a valid value");
                goto start;
            }
            else
            {
                Console.WriteLine("Input the number to be converted: ");
                string? input = Console.ReadLine();

                bool success = false;
                if (initialBase >= 2 || initialBase <= 9) success = Validator(input, initialBase);
                if (initialBase == 16) success = IsHexadecimalNumber(input);

                if (success)
                {
                    switch (resultBase)
                    {
                        case 10:
                            int decimalResult = ToBaseTenConverter(initialBase, input);
                            Console.WriteLine("Result is: " + decimalResult);
                            break;

                        case 2:
                            StringBuilder binaryResult = ToBaseTwoConverter(initialBase, input);
                            Console.WriteLine("Result is: " + binaryResult);
                            break;

                        case 16:
                            string HexResult = ToBaseSixteenConverter(initialBase, input);
                            Console.WriteLine("Result is: " + HexResult);
                            break;
                    }
                }

            }
        }
    }

    public static bool Validator(string number, int baseValue)
    {
        int n = 0;
        if (string.IsNullOrEmpty(number))
            return false;

        foreach (char num in number)
        {
            bool isANumber = int.TryParse(num.ToString(), out n);
            if (isANumber == false)
                return false;
            if (n < 0 || n > baseValue - 1)
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


    // converters
    public static int ToBaseTenConverter(int initialBase, string value)
    {
        int result = 0;
        int j = 0;

        for (int i = value.Length - 1; i >= 0; i--)
        {
            int convertedValue = (int)Math.Pow((initialBase), i) * int.Parse(value[j].ToString());

            result += convertedValue;
            j++;
        }
        return result;
    }

    public static StringBuilder ToBaseTwoConverter(int initialBase, string value)
    {
        int decimalResult = 0;
        int j = 0;
        int convertedValue = 0;
        StringBuilder finalResult = new StringBuilder();

        for (int i = value.Length - 1; i >= 0; i--)
        {
            convertedValue = (int)Math.Pow((initialBase), i) * int.Parse(value[j].ToString());

            decimalResult += convertedValue;
            j++;
        }
        while (convertedValue > 0)
        {
            int modulus = convertedValue % 2;

            finalResult.Insert(0, modulus);
            convertedValue /= 2;
        }
        return finalResult;
    }

    public static string ToBaseSixteenConverter(int initialBase, string value)
    {
        int decimalValue = ToBaseTenConverter(initialBase, value);

        string result = "";

        while (decimalValue > 0)
        {
            int modulus = decimalValue % 16;
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
            decimalValue /= 16;
        }
        return result;
    }

    // public static string 
}
