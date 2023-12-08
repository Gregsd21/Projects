/************************************************************************
* Name: Greg Arnold
* Date: 11/21/2023
*Assignment: CIS317 Week 3 GP - Constructors
*
*This class demonstrates constructor overloading by providing 3
*paramterized constructors and one no-arg constructor. Note that 
*the parameterized constructor that takes 3 parameters is really 
*the only constructor that "does" anything. The other constructors
*simply call the main constructor, ensuring that valid values are
*passed along with their parameter(s).
*
*The Datestring is used to either display the date information from 
*the class or to provide an error message. Get accessors are provided 
*in the event the class user wants to access only specific parts of
*the Date1 object.
*/

public class Date1
{
    public int Day {get; private set;}
    public string DayName {get; private set;}
    public int Month {get; private set;}
    public string Datestring {get; private set;}

    private readonly List<string> ValidDays = new List<string> {"Sunday",
        "Monday","Tuesday",  "Wednesday", "Thursday", "Friday", "Saturday"};

    public Date1(int day, string dayName, int month)
    {
        //Do some basic validation...nothing complex
        if (day < 1 || day > 31)
        {
            Datestring = "Invalid Day specified - must be in range 1 - 31\n";
            DayName = string.Empty;

        }
        else if (!ValidDays.Contains(dayName))
        {
            Datestring = "Invalid Day Name specified\n";
            DayName = string.Empty;
        }
        else if (month < 1 || month > 12)
        {
            Datestring = "Invalid Month specified - must be in range 1 -12\n";
            DayName = string.Empty;
        }
        else 
        {
            Day = day;
            DayName = dayName;
            Month = month;

            Datestring = GenerateDatestring();
        }
    }
    public Date1() : this(1, "Sunday", 1)
    {
       //Call our full constructor, giving it valid information
    }
    public Date1(int day, string dayName) : this(day, dayName, 1)
    {
         //Call our full constructor with the values we have, valid information
        //for what we don't
    }
    public Date1(int month) : this(1, "Sunday", month)
    {
         //Call our full constructor with the values we have, valid information
        //for what we don't
    }
    private string GenerateDatestring()
    {
        return string.Format(
            "Date string Created: \n{0}{1}\n{2}{3}\n{4}{5}\n",
            " Day: ", Day,
            " Day Name: ", DayName,
            " Month: ", Month);
    }
    public override string ToString()
    {
        return Datestring;
    }
}
