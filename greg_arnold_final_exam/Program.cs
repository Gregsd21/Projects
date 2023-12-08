/**********************************************************************
* Name: Greg Arnold
* Date:12/7/2023
* Assignment CIS317 Week 5 Final Practical Exam
*
*This class is the Main Application.
*/
using System.Text;
using System.Collections.Generic;
using System.IO;
public class FinalPractical
{
     private const string FILE_NAME = "Greg_Arnold_log.txt";
    public static void Main(string[] args)
    {   //This WriteToFile method is used to store values in the text file Greg_Arnold_log.txt
        WriteToFile();
        Console.WriteLine("\nGreg Arnold, Week 5 Final Practical Exam\n");
        //This WriteToFile method is used to store values in the text file Greg_Arnold_log.txt
        WriteToFile("Starting the application.\n");
        
        List<Building> buildings = new List<Building>{
        new House(5,new Door(56, "Dark Brown"),new Kitchen("Modern", "Maytag")),
        new House(4,new Door(48, "Blue"),new Kitchen("Country", "Whirlpool")),
        new House(8,new Door(36, "Green"),new Kitchen("Chef's", "Bosch")),
        new House(9,new Door(108, "Black"),new Kitchen("Farmhouse", "GE")),
        new House(3,new Door(96, "White"),new Kitchen("Minimalist", "Kenmore"))
        };
        //This WriteToFile method is used to store values in the text file Greg_Arnold_log.txt
        WriteToFile("Buildings ArrayList created and filled.\n");
        Console.WriteLine("\nIteractive Printing of Buildings\n");
        IterativeBuildings(buildings, "Iterative");
        //This WriteToFile method is used to store values in the text file Greg_Arnold_log.txt
        WriteToFile("Iterative print complete.\n");
        Console.WriteLine("\nRecursive Printing of Buildings\n");
        RecursiveBuildings(buildings, 0);
        //This WriteToFile method is used to store values in the text file Greg_Arnold_log.txt
        WriteToFile("Recursive print complete.\n");
       
        Console.WriteLine(ReadFromFile());
    }

    private static string WriteToFile()
    {
        //Write to a file;  if the file doesn't exist, it will be created;
        //if it does exist, it will be overwritten.
        File.WriteAllText(FILE_NAME, "Contents of Log File" + Environment.NewLine);
        
        return "Contents of Log File:\n";
    }
     private static string WriteToFile(string s)
    {
    //Append text to a file; if the file doesn't exist it will be created
        File.AppendAllText(FILE_NAME,s);
        return "Successfully wrote to the file.\n";
    }
    //Read from a file - return a message indicating the file contents were 
    //printed
    private static string ReadFromFile()
    {
        //Read all the lines from the named file into a string array
        string[] readText = File.ReadAllLines(FILE_NAME);

        //print each line from the file to the console
        foreach (string s in readText)
        {
            Console.WriteLine(s);
        }
        return "Program Terminating.";
    }

    private static void IterativeBuildings(List<Building> buildings, string b)
    {
        foreach (Building building in buildings)
        {
            Console.Write(building + "\n");
        }
    }
    private static void RecursiveBuildings(List <Building> buildings, int i)
    {
        if (i >= 0 && i <=4)
        {
            Console.Write(buildings[i]);
            RecursiveBuildings(buildings, i+1);
            
        }
        else
        {
           Console.Write("No More Listings\n\n");
        }
    }
}