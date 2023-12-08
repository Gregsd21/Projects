/***********************************************************************************************
*Name: Greg Arnold
*Date:11/16/2023
*CIS Performance Assessment- Polymorphism
*This class is the Condominium class that has the properties NumUnits and the data from the ToString override of the Building class.
*/
public class Condominium : Building
{
    public int NumUnits {get; set;} 

    public Condominium(int numFloors, string streetAddress, string exteriorMaterials, int numUnits)
    : base(numFloors,streetAddress,exteriorMaterials)
    {
        NumUnits=numUnits;
    }
    public override string ToString()
    {
        return string.Format(
            "{0} It is a condominium that contains {1} units.",
            base.ToString(),NumUnits);
        
    }
}

