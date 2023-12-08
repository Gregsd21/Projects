/***********************************************************************************************
*Name: Greg Arnold
*Date:11/16/2023
*CIS Performance Assessment- Interface Class- Creating a Vehicle
*This class implements the IVehicle interface. This class will have all override information to define a car and its methods for the class.*/

public class Car: IVehicle
{
    private string m_make {get;set;}
    private string m_model{get;set;}
    private bool m_running{get;set;}
    private string m_destination{get;set;}

public Car(string make, string model, bool running, string destination)
{
m_make = make;
m_model = model;
m_running = running;
m_destination= destination;
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
{    string runnin = m_running ? "is" : "is not";
    return string.Format("Make: {0}\nModel: {1}\nThe car {2} running and heading to {3}\n",m_make,m_model, runnin, m_destination); 

}
}