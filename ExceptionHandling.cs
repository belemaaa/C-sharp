namespace CSHARPTUTORIAL;
using System;
using System.IO;

class Exceptionhandling
{
    public static void EH()
    {
        try
        {
            // this type reads the content of a file and outputs it
            StreamReader streamReader = new StreamReader(@"/Users/graceitamunoala/Documents/C-sharp/data.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Please check if the file {ex.FileName} exists");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}