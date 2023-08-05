using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"D:\LTGD\text.txt"; // Path to the input file

        try
        {
            string content = File.ReadAllText(filePath);

            Console.WriteLine("Contents of the file:");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found: " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
