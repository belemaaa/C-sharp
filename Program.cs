﻿using System.Data;
using System;
using static CSHARPTUTORIAL.ShoppingList;
using static CSHARPTUTORIAL.Calculator;
using static CSHARPTUTORIAL.SwitchStatement;

namespace CSHARPTUTORIAL;

class Program
{
    public static void Main(string[] args)
    {
        int total = 0;
        int product = 0;

        SimpleMethod(10, 20, out total, out product);
        Console.WriteLine($"Sum is {total}, product is {product}");
    }

    public static void SimpleMethod(int num1, int num2, out int sum, out int product){
        sum = num1 + num2;
        product = num1 * num2;

    }
}
