/***********************************************************************************************
*Name: Greg Arnold
*Date:11/16/2023
*CIS Performance Assessment- Polymorphism
*This class is the base class Building which all the other classes can inherit its properties via overridingof the ToString().
*/
public class Building
{
    public string StreetAddress {get; set;}
    public int NumFloors {get; set;}
    public string ExteriorMaterials {get; set;}

    public Building(int numFloors,string streetAddress, string exteriorMaterials)
    {
        StreetAddress = streetAddress;
        NumFloors = numFloors;
        ExteriorMaterials = exteriorMaterials;
    }

    public override string ToString()
    {
        return string.Format(
            ">> There is a {0} story building at {1} made of {2}.", NumFloors, StreetAddress, ExteriorMaterials);
    }
}