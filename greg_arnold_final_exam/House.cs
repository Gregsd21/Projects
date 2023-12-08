/**********************************************************************
* Name: Greg Arnold
* Date:12/7/2023
* Assignment CIS317 Week 5 Final Practical Exam
*
*This is the House class which will utilize Building as the superclass. In this class,
* 3 private properties are added and uses a constructor for those 3 properties. It contains
*a GetRooms method to get the room #, and a ToString to set the description of the string to be used in the application.
*/

//Demonstrates Inheritance
public class House: Building
{   //Demonstrates Access Specifiers
    private int NumRooms { get; set; }
    private Door FrontDoor {get; set;}
    private Kitchen MainKitchen {get; set;}
//Constructor 
public House(int numRooms, Door frontDoor,Kitchen mainKitchen)
: base("House")
    {
        NumRooms = numRooms;
        FrontDoor = frontDoor;
        MainKitchen = mainKitchen;
    }
    public override int GetRooms()
    {
        return NumRooms;
    }
    public override string ToString()
    {
     return string.Format(
            "This is a/an House. It has {0} rooms.\n{1}\n{2}\n",
            NumRooms, FrontDoor,MainKitchen);
    }
}