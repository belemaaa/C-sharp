namespace CSHARPTUTORIAL;

public class Calculator
{
    public static void Calculate()
    {
        bool runAgain = true;

        while (runAgain == true)
        {
            Console.WriteLine(
                "What operation do you wish to perform? \n -addition \n -subtraction \n -multiplication \n -division"
            );
            string? input = Console.ReadLine();

            Console.WriteLine("Enter two numbers: ");
            bool success1 = int.TryParse(Console.ReadLine(), out int num1);
            bool success2 = int.TryParse(Console.ReadLine(), out int num2);

            if (success1 == true && success2 == true)
            {
                if (input == "addition")
                {
                    Console.WriteLine("{0} + {1} = {2} ", num1, num2, Calculator.Add(num1, num2));
                }

                else if (input == "subtraction")
                {
                    Console.WriteLine("{0} - {1} = {2} ", num1, num2, Calculator.Sub(num1, num2));
                }

                else if (input == "multiplication")
                {
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, Calculator.Mul(num1, num2));
                }

                else if (input == "division")
                {
                    if (num2 != 0)
                    {
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, Calculator.Div(num1, num2));
                    }
                    else
                    {
                        Console.WriteLine("Divisor cannot be 0");
                    }
                }

                else {
                    Console.WriteLine("Invalid input");
                }

                Console.WriteLine("Do you wish to perform another operation? \n -yes \n -no");
                string? response = Console.ReadLine();
                if (response == "yes")
                {
                    runAgain = true;

                }
                else if (response == "no")
                {
                    runAgain = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid response.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid inputs");
            }
        }
    }

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Sub(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Mul(int num1, int num2)
    {
        return num1 * num2;
    }

    public static double Div(int num1, int num2)
    {
        return num1 / num2;
    }
}

