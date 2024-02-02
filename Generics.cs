namespace CSHARPTUTORIAL;

public class Generics
{
    public static void GenericsOps()
    {
        bool equal = Calculator.AreEqual<string>("grace", "grace");
    }

    public class Calculator
    {
        // generics make yoir code type independent
        // it allows you specify the data type to be sent to the method during method call
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
