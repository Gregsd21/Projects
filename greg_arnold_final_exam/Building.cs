/**********************************************************************
* Name: Greg Arnold
* Date:12/7/2023
* Assignment CIS317 Week 5 Final Practical Exam
*This is an abstract class that is used to represent a Building.
*It has an abstract defintion, as well as a ToString method to return a type of building
*/

public abstract class Building 
{
    //properties for this class
    private string BuildingType { get; set; }

    //Protected constructor for this class
    protected Building(string buildingType)
    {
        BuildingType = buildingType;
    }
    public abstract int GetRooms();
    public override string ToString()
    {
        return BuildingType;
    }
}

