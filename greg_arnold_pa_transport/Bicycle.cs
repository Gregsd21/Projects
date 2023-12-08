/************************************************************
* Name: Greg Arnold
* Date: 11/9/2023
* Assignment: CIS317 Week 1 PA - Demonstrating Inheritance - Modes of Transportation
* This class is a child of the "Vehicle" class and adds three new properties that identify the class as a bicycle.
*/
public class Bicycle : Vehicle
{
    public int Gears {get; set;}
    public double SeatHeight {get; set;}
    public double TireSize {get; set;}

    public Bicycle(string color, int wheels, int seats, bool moving, int gears, double seatheight, double tiresize )
    : base(color,wheels,seats,moving)
    {
        Gears = gears;
        SeatHeight = seatheight;
        TireSize = tiresize;
    }
     public override string GetVehicleInfo()
    {
        return string.Format("{0}Number of Gears: {1}\nBicycle Height: {2}\n",
            base.GetVehicleInfo(), Gears, SeatHeight);
    }

}