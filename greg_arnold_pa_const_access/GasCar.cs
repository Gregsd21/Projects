/**************************************************************************************
*Name: Greg Arnold
*Date: 11/25/2023
*Assignment: CIS317 Week3 Performance Assessment - Constructors and Access Specifiers

*This is a class representing a gas car with extra methods for gas cars.
*/

public class GasCar : Car
{
    public GasCar(string fuel, string engine)
    : base(fuel, engine)
    {

    }
    public GasCar(string engine)
    : base("GasCar", engine)
    {

    }
    public void UpdateFuel(string fuelType)
    {
        Fuel = fuelType;
    }
    }