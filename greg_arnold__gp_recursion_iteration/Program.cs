/******************************************************************************************
* Name: Greg Arnold
* Date: 12/5/2023
*Assignment: CIS317 Week 5 GP - Recursion & Iteration
*
*Main application class.
*/
using System.Text;

public class RecursionIterationDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nGreg Arnold, Week 5 Recursion & Iteration GP\n");
        Console.WriteLine("Iterative Countdown from 10:");
        IterativeCountdown(10);
        Console.WriteLine("\n\nRecursive Countdown from 10:");
        RecursiveCountdown(10);
        Console.WriteLine("\n\nIterative Name Reverse:");
        Console.WriteLine(IterativeNameReverse("Greg Arnold"));
        Console.WriteLine("\nRecursive Name Reverse:");
        Console.WriteLine(RecursiveNameReverse("Greg Arnold"));
    }
    private static void IterativeCountdown(int startNum)
    {
        for (int i = startNum; i > 0; i--)
        {
            Console.Write(i + ", ");
        }
        Console.Write("Blastoff!");
    }
    private static void RecursiveCountdown(int startNum)
    {
        if (startNum == 0)
        {
            Console.Write("Blastoff!");
        }
        else{
            Console.Write(startNum + ", ");
            RecursiveCountdown(startNum -1);
        }
    }
    /* Re-build the string using a stringBuilder starting at the end of the 
    string and working your way back to the beginning of the string. */
    private static string IterativeNameReverse(string name)
    {
        StringBuilder reverseName = new StringBuilder();
        char[] strChars = name.ToCharArray();
        for (int i = name.Length -1; i >= 0; i--)
        {
            reverseName.Append(strChars[i]);
        }
        return reverseName.ToString();
    }
    /*Re-build the string by taking a substring of the string starting at
    index 1 and adding the character at index 0 to the end of that string, 
    repeating the process until the string is empty, which yields the final 
    return value, the reversed string. */
    private static string RecursiveNameReverse(string name)
    {
        if (name.Length == 0)
        {
            return "";
        }
        else
        {
            return RecursiveNameReverse(name.Substring(1)) + name.Substring(0, 1);
        }
    }
}