namespace CSHARPTUTORIAL;

class Program
{
    public static void Main(string[] args)
    {
        Program.EvenNumbers(5);

        Program animal = new Program();
        animal.Animal("Cat");
    }

    public static void EvenNumbers(int Target){
        int count = 0;
        while (count <= Target){
            Console.WriteLine(count);
            count += 2;
        }
    }

    public void Animal(string type){
        Console.WriteLine("This is a {0}", type);
    }
}
