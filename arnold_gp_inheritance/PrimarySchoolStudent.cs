/************************************************************
* Name: Greg Arnold
* Date: 11/7/2023
* Assignment: CIS317 Week 1 GP - Inheritance
*
* This class represents a PrimarySchoolStudent object, which is derived
* from the Student class by adding the student's grade. A constructor is
* provided to set all class and base class properties. The ToString is 
* overridden and calls the GetStudentInformation method is also overriden and
* formatted data. The GetStudentInformation method is also overridden and 
* calls the base class GetStudentInformation method to get that class data.
*/
public class PrimarySchoolStudent : Student
{
    public string Grade { get; set; }

    //3-parameter constructor to set the parent and this class's properties 
    public PrimarySchoolStudent(string name, string school, string grade)
        : base(name, school)
    {
        Grade = grade;
    }

    //First technique for an extended class: override the 
    //super/parent/base class function, calling the base 
    //class implementation first
    public override string GetStudentInformation()
    {
        return string.Format("{0}\nStudent Grade: {1}",
            base.GetStudentInformation(), Grade);
    }

    public override string ToString()
    {
        return GetStudentInformation();
    }
}