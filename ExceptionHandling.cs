namespace CSHARPTUTORIAL;
using System;
using System.IO;

class Exceptionhandling
{
    public static void EH()
    {
        // this type reads the content of a file and outputs it
        StreamReader streamReader = new StreamReader(@"/Users/graceitamunoala/Documents/C-sharp/data.txt");
        Console.WriteLine(streamReader.ReadToEnd());
        streamReader.Close();
    }
}