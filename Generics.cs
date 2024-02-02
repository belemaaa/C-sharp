namespace CSHARPTUTORIAL;

public class Generics
{
    public static void GenericsOps()
    {
        bool equal = Calculator<string>.AreEqual("grace", "grace");
    }

    public class Calculator<T>
    {
        // generics make yoir code type independent
        // it allows you specify the data type to be sent to the method during method call
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
