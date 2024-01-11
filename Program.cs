namespace CSHARPTUTORIAL;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your target value: ");
        int targetValue = int.Parse(Console.ReadLine());

        int count = 0;
        while (count <= targetValue){
            Console.WriteLine("Count {0}", count);
            count += 1;
        }

    }
}
