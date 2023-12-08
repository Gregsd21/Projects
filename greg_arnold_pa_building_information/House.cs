/***********************************************************************************************
*Name: Greg Arnold
*Date:11/16/2023
*CIS Performance Assessment- Polymorphism
*This class is of the House class which contributes properties Color, NumRooms, and uses
*a ToString override to add the Buidling information to give the accurate description of the house build.
*/

public class House: Building
{
    public string Color {get;set;}
    public int NumRooms {get;set;}

    public House (int numFloors, string streetAddress, string exteriorMaterials,string color, int numRooms)
    :base(numFloors,streetAddress,exteriorMaterials)
    {
        Color=color;
        NumRooms=numRooms;
    }
    public override string ToString()
    {
        return string.Format(
            "{0} It is a {1} house that contains {2} rooms.",
            base.ToString(),Color,NumRooms);
    }

}