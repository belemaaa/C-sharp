namespace CSHARPTUTORIAL;

class Program
{
    static void Main(string[] args)
    {
        // while loop
        Console.WriteLine("Enter your target value: ");
        int targetValue = int.Parse(Console.ReadLine());

        int count = 0;
        while (count <= targetValue){
            Console.WriteLine("Count {0}", count);
            count += 1;
        }

        // do while loop
        int[] Numbers = new int[3];
        Numbers[0] = 1;
        Numbers[1] = 2;
        Numbers[2] = 3;

        int i = 0;
        do{
            Console.WriteLine(Numbers[i]);
            i++;
        }
        while (i < Numbers.Length);

        // for loop
        for (int j = 0; j < Numbers.Length; j++){
            Console.WriteLine("\n" + Numbers[j]);
        }

        // foreach loop
        foreach(int number in Numbers){
            Console.WriteLine(number);
        }
    }
}
