/************************************************************
* Name: Greg Arnold
* Date: 11/9/2023
* Assignment: CIS317 Week 1 PA - Demonstrating Inheritance - Modes of Transportation
*The class is a child of the "Motorized" class and adds two additional properties that makes it a car. 
*/
public class Car : Motorized
{
    public bool SunRoof {get; set;}
    public string Storage {get; set;}

    public Car(string color, int wheels, int seats, bool moving, string engine, bool automatic, string storage, bool sunroof)
    : base(color,wheels,seats,moving, engine, automatic)
    {
        SunRoof = sunroof;
        Storage = storage;
    }
   
     public override string GetVehicleInfo()
    {
    return string.Format(
        "Color: {0}\n# of Seats: {1}\nEngine Size: {2}\nAutomatic Transmission? {3}\nHas Sunroof? {4}\nStorage: {5}\n", 
        Color,Seats,Engine,Automatic,SunRoof,Storage);
    }
     public override string ToString()
    {
    return string.Format(
        "{0}Storage: {1}\nHas Sunroof? {2}\n",
        base.GetVehicleInfo(),Storage, SunRoof);
    }
    /*public override string ToString()
    {
        return GetVehicleInfo();
    }
    */

}