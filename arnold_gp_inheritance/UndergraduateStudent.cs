/************************************************************
* Name: Greg Arnold
* Date: 11/7/2023
* Assignment: CIS317 Week 1 GP - Inheritance
*
* This class represents an UndergraduateStudent object, which is
* derived from the CollegeStudent class by adding the student's
* year. A constructor is provided to set all class and base class 
* properties. The ToString method is overridden and calls the 
* GetStudentInformation method to provide the formatted properties. 
* The GetStudentInformation method is also overridden and does not
* call the base class's method; rather it accesses the base class
* properties directly to provide a different format.
*/
public class UndergraduateStudent : CollegeStudent
{
    public string Year { get; set; }

    public UndergraduateStudent(string name, string school, string major,
        string year) : base(name, school, major)
        {
            Year = year;
        }


//Yet another technique... don't use the base class 
//implementation at all - make our own functionality
//using the base class's properties directly (and, in this
//case, the base class's parent as well)
public override string GetStudentInformation()
{
    return string.Format(
        "Student Name: {0}\nCollege Name: {1}\nStudent Year: {2}\n"
            + "Student Major: {3}",
        Name,      //from the Student class
        SchoolName, //from the Student class
        Year,       //this class's property
        Major);    //from the CollegeStudent class
}

public override string ToString()
{
    return GetStudentInformation();
}
}