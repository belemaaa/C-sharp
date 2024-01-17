using System.Data;
using System;
using static CSHARPTUTORIAL.ShoppingList;
using static CSHARPTUTORIAL.Calculator;
using static CSHARPTUTORIAL.SwitchStatement;
using static CSHARPTUTORIAL.Classes;

namespace CSHARPTUTORIAL;

class Program
{
    public static void Main(string[] args)
    {
        // int total = 0;
        // int product = 0;

        // SimpleMethod(10, 20, out total, out product);
        // Console.WriteLine($"Sum is {total}, product is {product}");

        // int[] Numbers = new int[3];
        // Numbers[0] = 1;
        // Numbers[1] = 2;
        // Numbers[2] = 3;

        // ParamsMethod(Numbers);

        ClassesLesson();
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
