/************************************************************
* Name: Greg Arnold
* Date: 11/9/2023
* Assignment: CIS317 Week 1 PA - Demonstrating Inheritance - Modes of Transportation
*
* This class represents a Vehicle object, which is "ultimate" base 
* class in this exercise. All other classes are derived from this
* class at some level. This class includes Wheels and Color, Seats, and Moving status
* properties. The constructor takes parameters to set all properties.
* ToString is overriden and calls the GetVehicleInfo method to 
* provide the formatted data.
*/

public class Vehicle
{
//Properties for this class
  public int Wheels { get; set; }
  public string Color { get; set; }
  public bool Moving { get; set; }
  public int Seats {get; set; }

//Constructor
public Vehicle(string color, int wheels, int seats, bool moving)
    {
        Wheels = wheels;
        Color = color;
        Moving = moving;
        Seats = seats;
    }
//Override method
public virtual string GetVehicleInfo()
    {
        return string.Format("Color: {0}\nWheel Count: {1}\nSeat Count: {2}\nCurrently Moving: {3}\n",
            Color, Wheels, Seats, Moving );
    }
     
}