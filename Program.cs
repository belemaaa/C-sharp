using System.Data;
using System;
using static CSHARPTUTORIAL.ShoppingList;
using static CSHARPTUTORIAL.Calculator;
using static CSHARPTUTORIAL.SwitchStatement;
using static CSHARPTUTORIAL.Classes;
using static CSHARPTUTORIAL.Properties;

namespace CSHARPTUTORIAL;

class Program
{
    public static void Main(string[] args)
    {
        PropertiesOps();
    }

    public static void SimpleMethod(int num1, int num2, out int sum, out int product)
    {
        sum = num1 + num2;
        product = num1 * num2;

    }

    // creating a parameter array
    public static void ParamsMethod(params int[] Numbers) //omit the params keyword to make the array parameter optional
    {
        Console.WriteLine(Numbers.Length);
        foreach (int number in Numbers){
            Console.WriteLine(number);
        }
    }
}
