namespace CSHARPTUTORIAL;
using System;
using System.IO;

class Exceptionhandling
{
    public static void EH()
    {
        StreamReader streamReader = null;
        try
        {
            // this type reads the content of a file and outputs it
            streamReader = new StreamReader(@"/Users/graceitamunoala/Documents/C-sharp/data.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Please check if the file {ex.FileName} exists");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            streamReader?.Close();

            Console.WriteLine("Finally block");
        }

    }
}

/* streamReader reads to a file, streamWriter writes to a file
    to create a streamWriter: 
    const text = "testing the StringWriter

    string filePath = @"path here";
    StreamWriter sw = new StreamWriter(filePath);

    sw.write(text);
    sw.Close;
    
    Console.WriteLine("There is an exception, please try again.)
*/
