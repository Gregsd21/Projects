/***********************************************************************************************
*Name: Greg Arnold
*Date:11/16/2023
*CIS Performance Assessment- Interface Class- Creating a Vehicle
*This class is the base class Building which all the other classes can inherit its properties via overridingof the ToString().
*/

public class CargoTruck: IVehicle
{
    private string m_make {get;set;}
    private string m_model{get;set;}
    private bool m_running{get;set;}
    private string m_destination{get;set;}
    private string CargoCapacity {get;set;}

public CargoTruck(string make, string model, bool running, string destination, string capacity)
{
m_make = make;
m_model = model;
m_running = running;
m_destination= destination;
CargoCapacity = capacity;
}
public string GetMake()
{
    return m_make;
}
public string GetModel()
{
    return m_model;
}
public void Start()
{
    m_running = true;
}
public void Stop()
{
    m_running = false;
}
public void Drive(string destination)
{
 Console.WriteLine(destination);
}

public override string ToString()
{   string runnin = m_running ? "is" : "is not";
    return string.Format(
   "Make: {0}\nModel: {1}\nThe truck {2} running and hauling {3} of cargo to {4}\n",m_make, m_model, runnin, m_destination, CargoCapacity);

}
}