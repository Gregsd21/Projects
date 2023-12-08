/*******************************************************************
*Name: Greg Arnold
*Date: 11/28/2023
*Assignment: CIS317 Week 4 GP - Binary Files
*
*Main application class.
*/
using System.IO;

public class BinaryFileDemo
{
    private const string FILE_NAME = "GregArnold.dat";
    public static void Main(string[] args)
    {
        Console.WriteLine("\nGreg Arnold, Week 4 Text Files GP\n");
        Console.WriteLine(WriteToFile());
        Console.WriteLine(ReadFromFile());
    }
    //Write to a file - on completion, return a message indicating
    //success or an error message if an arror occurs
    public static string WriteToFile()
    {
        try
        {
            using (BinaryWriter bWriter =
                new BinaryWriter(File.Open(FILE_NAME, FileMode.Create)))
            {
                Console.WriteLine("Starting to write to file");
                //Write a string
                bWriter.Write("String written in binary.");
                //Write an integer
                bWriter.Write(5);
                //Write a double
                bWriter.Write(9.95F);
                //Write a boolean
                bWriter.Write(true);
                Console.WriteLine("Finished writing to file\n");
                return "Write completed successfully\n";
            }
        }
        catch (IOException e)
        {
            return "An error occured: " + e.Message;
        }
    }

    //Read from a file - if successful, return a message indicating 
    //the file contents were printed; if an error occurs, return a 
    //message stating an error occurred
    public static string ReadFromFile()
    {
        try
        {
            using (BinaryReader bReader =
                new BinaryReader(File.Open(FILE_NAME, FileMode.Open)))
            {
                Console.WriteLine("Starting to read from file");
                //Read a string
                Console.Write("String value from file: ");
                Console.WriteLine(bReader.ReadString());
                //Read an integer
                Console.Write("Integer value from file: "); 
                Console.WriteLine(bReader.ReadInt32());
                //Read a double
                Console.Write("Double value from file: ");
                Console.WriteLine(bReader.ReadSingle());
                //Read a boolean
                Console.Write("Boolean value from file: ");
                Console.WriteLine(bReader.ReadBoolean());
                Console.WriteLine("Finished reading from file\n");
                return "Reading completed successfully";

                
            }
        }
        catch (IOException e)
        {
            return "An error occurred: " + e.Message;
        }
    }
}