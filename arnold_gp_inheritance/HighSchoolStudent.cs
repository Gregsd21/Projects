/************************************************************
* Name: Greg Arnold
* Date: 11/7/2023
* Assignment: CIS317 Week 1 GP - Inheritance
*
* This class represents a HighSchoolStudent object, which is derived
* from the Student class by adding the student's grade, class name, 
*and an indicator of whether or not the student is in a college prep 
*program. A constructor is provided to set all class and base class
*properties. The ToString is overridden and calls the
*GetStudentInformation method from the base class to provide the
*formatted data. The GetStudentInformation method is not overridden,
*so only the super class data will be returned by calls to that method.
*/public class HighSchoolStudent : Student
{
    public int Grade { get; set; }
    public string ClassName { get; set; }
    public bool IsCollegePrep {get; set; }

    //5-parameter constructor to set the parent and this class's properties
    public HighSchoolStudent(string name, string school, int grade,
        string clsName, bool collPrep) : base(name, school)
    {
        Grade = grade;
        ClassName = clsName;
        IsCollegePrep = collPrep;
    }

    //Second technique for an extended class: leave the 
    //super/parent/base class function alone - don't implement 
    //anything for the GetStudentInformation method

    //Override the ToString() method calling the base class
    //GetStuentInformation function for the initial part of
    //the string = note we don't need a keyword to call the function
    //because we don't have our own implementation of that function
    public override string ToString()
    {
        return string.Format(
            "{0}\nStudent Grade: {1:D}\nStudent Class: {2}\nCollege Prep? {3}",
            GetStudentInformation(), Grade, ClassName, IsCollegePrep);
    }

}