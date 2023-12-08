/***********************************************************************************************
*Name: Greg Arnold
*Date:11/16/2023
*CIS Performance Assessment- Interface Class- Creating a Vehicle
*This class is the interface class that defines all methods that classes that implement this interface must implement.
*/

public interface IVehicle
{
    string GetMake();
    string GetModel();
    void Start();
    void Stop();
    void Drive(string destination);

}