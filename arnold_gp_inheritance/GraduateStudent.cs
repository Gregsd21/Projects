/************************************************************
* Name: Greg Arnold
* Date: 11/7/2023
* Assignment: CIS317 Week 1 GP - Inheritance
*
* This class represents a GraduateStudent object, which is derived
* from the CollegeStudent class by adding an indicator for whether 
* or not a thesis is required for the student. A constructor is provided
* to set all class and base class properties. ToString is overriden 
* and calls the base class GetStudentInformation method to get that
* class's formatted properties. The GetStudentInformation method is 
* also overriden in the same manner.
*/
public class GraduateStudent : CollegeStudent
{
    public bool ThesisRequired {get; set; }

    //4-parameter constructor to set the parent and this class's properties 
    public GraduateStudent(string name, string school, string major,
        bool thesis) : base(name, school, major)
    {
        ThesisRequired = thesis;
    }

    //Override the GetStudentInformation function, calling
    //the base class's function and adding our information
    public override string GetStudentInformation()
    {
        return string.Format("{0}\nThesis Required? {1}",
            base.GetStudentInformation(), ThesisRequired);
    }

    //Override the ToString() method calling the base class's
    //GetStudentInformation then adding our information
    public override string ToString()
    {
        return string.Format("{0}\n{1}",
            base.GetStudentInformation(), ThesisRequired);
    }
}