/************************************************************
* Name: Greg Arnold
* Date: 11/9/2023
* Assignment: CIS317 Week 1 PA - Demonstrating Inheritance - Modes of Transportation
*The class is a child of the "Motorized" class and adds two new properties to make it a truck.
*/
public class Truck : Motorized
{
    public string Load {get; set;}
    public bool TowingEnabled {get; set;}

    public Truck(string color, int wheels, int seats, bool moving, string engine, bool automatic, bool towingenabled, string load)
    : base(color,wheels,seats,moving,engine,automatic)
    {
        Load = load;
        TowingEnabled = towingenabled;
    }
    /* public override string GetVehicleInfo()
    {
    return string.Format(
        "Engine: {0}\nAutomatic Transmission? {1}",
        base.GetVehicleInfo(),Engine, Automatic);
    }*/
public override string ToString()
    {
    return string.Format(
        "{0}",
        base.GetVehicleInfo());
    }

}