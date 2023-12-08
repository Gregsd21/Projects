/************************************************************
* Name: Greg Arnold
* Date: 11/9/2023
* Assignment: CIS317 Week 1 PA - Demonstrating Inheritance - Modes of Transportation
*This class uses the parent class "Vehicle" and adds on two additional properties that would make a vehicle motorized.
*/
public class Motorized : Vehicle
{
    //properties unique to this class
    public string Engine { get; set; }
    public bool Automatic { get; set;}

    public Motorized(string color, int wheels, int seats, bool moving, string engine, bool automatic)
    : base(color,wheels,seats,moving)
    {
        Engine = engine;
        Automatic = automatic;
    }
     public override string GetVehicleInfo()
    {
        return string.Format("{0}Engine: {1}\nAutomatic Transmission? {2}\n",
            base.GetVehicleInfo(), Engine, Automatic);
    }

}