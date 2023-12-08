/***********************************************************************************************
*Name: Greg Arnold
*Date:11/16/2023
*CIS Performance Assessment- Polymorphism
*This class is of the SplitLevel class which contributes properties EntryLevelLivingSpace and sets the Building class NumFloors to 2. This class also uses
*a ToString override to add the Buidling information to give the accurate description of the SplitLevel build.
*/
public class SplitLevel : House
{
    public bool EntryLevelLivingSpace {get;set;}

    public SplitLevel(int numFloors, string streetAddress, string exteriorMaterials,string color, int numRooms, bool entryLevelLivingSpace)
    :base(numFloors,streetAddress,exteriorMaterials,color,numRooms)
    {
        EntryLevelLivingSpace = entryLevelLivingSpace;
        NumFloors = 2;
    }
     public override string ToString()
    {
        string entrySpace = EntryLevelLivingSpace ? "has" : "does not have";
        return string.Format(
            "{0} It is a Split-Level that {1} entry level living space.",
            base.ToString(),entrySpace);
    }

}