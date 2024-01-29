namespace CSHARPTUTORIAL;

public class NumWord{

    public static void Converter(){
        Console.WriteLine("Input a number between 0 and 10000");
        string? number = Console.ReadLine();

        bool success = IsNumberValid(number);
        if (success){
            Console.WriteLine($"{number} in words: {PrintWord(number)}");
        }
        else{
            Console.WriteLine("Invalid number");
        }
    }

    public static bool IsNumberValid(string number){
        int n;
        if (string.IsNullOrEmpty(number))
            return false;

        foreach (char num in number){
            bool isANumber = int.TryParse(number.ToString(), out n);
            if (isANumber == false)
                return false;
            if (n < 0 || n > 10000)
                return false;
        }
        return true;
    }

    public static string PrintWord(string number){
        string[] units = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
        string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "","ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] thousands = {"thousand", "million", "billion", "trillion", "quadrillion", "quintillion" };

        int num = int.Parse(number.ToString());
        string words = "";

        //if (num == 0) return "zero";
        if (num < 10) return units[num];
        if (num >= 11 && num <= 19) return teens[num - 11];

        if (num >= 1000)
        {
            words += units[num / 1000] + " " + thousands[0];
            num %= 1000;
            if (num > 0)
            {
                words += " and ";
            }
        }

        if (num >= 100)
        {
            words += units[num / 100] + " hundred";
            num %= 100;
            if (num > 0)
            {
                words += " and ";
            }
        }

        if (num >= 10)
        {
            words += tens[num / 10];  
            num %= 10;
            if (num > 0)
            {
                words += " ";
            }
        }

        if (num > 0)
        {
            words += units[num];
        }

        return words;
    }
        

    }
