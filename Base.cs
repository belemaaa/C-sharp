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
                    bool tryBaseTenInput = int.TryParse(Console.ReadLine(), out int baseTenInput);

                    if (tryBaseTenInput)
                    {

                    }
                    break;
            }
        }
    }

    public static void BaseTenToTwoConverter(string value)
    {
        StringBuilder result = new StringBuilder();

        foreach (char digit in value)
        {
            int convertedValue = int.Parse(digit.ToString()) % 2;
            result.Append(convertedValue);
        }
        Console.WriteLine(result);
    }

    public static void BaseTwoToTenConverter(string value)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < value.Length; i++){
            int convertedValue = (int)Math.Pow((value[i] * 2), i);

            result.Append(convertedValue);
        }
        Console.WriteLine(result);
    }
}

