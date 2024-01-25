namespace CSHARPTUTORIAL;

public class NumWord{

    public static void Converter(){
        Console.WriteLine("Input a number between 0 and 1000");
        string? number = Console.ReadLine();

        bool success = IsNumberValid(number);
        if (success){
            Console.WriteLine($"{number} in words: ");
        }
    }

    public static bool IsNumberValid(string number){
        int n;
        if (string.IsNullOrEmpty(number))
            return false;

        bool isANumber = int.TryParse(number.ToString(), out n);
            if (isANumber == false)
                return false;
            if (n < 0 || n > 10000)
                return false;
        return true;
    }
}