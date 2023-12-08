/*********************************************************************
* Name: Greg Arnold
* Date:11/21/2023
* Assignment: CIS317 Week 3 GP – Access Specifiers
*
* This class demonstrates using public and private access specifiers.
*  The class property is visible publicly, but can only be set via the
* public update functions as the set accessor is declared private.

*/
public class Student : Person
{
    public int GradYear {get; private set;}
    public Student(string name, double age, string email, int gradYear)
        : base(name, age, email)
    {
        if (gradYear > 1900)
        {
            GradYear = gradYear;
        }
        else
        {
            GradYear = 1900;
        }
    }
    public void UpdateGradYear(int gradYear)
    {
        //only set the grad year if it's > 1900
        if (gradYear > 1900)
        {
            GradYear = gradYear;
        }
    }
    //methods to update base class info, demonstrating access from 
    //the derived class
    public void UpdateName(string name)
    {
        Name = name;
    }
    public void UpdateAge(double age)
    {
        Age = age;
    }
    public void UpdateEmail(string email)
    {
        Email = email;
    }
    public override string ToString()
    {
        return
            "Student Information for " + Name + "\n" +
            "   Age: " + Age + "\n" +
            "   Email: " + Email + "\n" + 
            "   Graduation Year: " + GradYear + "\n";
    }
}