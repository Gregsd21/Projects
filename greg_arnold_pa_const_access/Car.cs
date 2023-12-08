/**************************************************************************************
*Name: Greg Arnold
*Date: 11/25/2023
*Assignment: CIS317 Week3 Performance Assessment - Constructors and Access Specifiers

*This is the base class representing a basic car with properties for fuel and engine types
*/

public class Car
{
    protected string Fuel {get; set;}
    protected string Engine {get;set;}
    protected Car(string fuel, string engine)
    {
        Fuel = fuel;
        Engine = engine;
    }
    public override string ToString()
    {
    return 
    
    "Car Type: "+ GetType().Name + "\n" +
    "Engine Type: "+ Engine + "\n"+
    "Fuel Type: "+ Fuel + "\n";
}
    
}