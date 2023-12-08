/**********************************************************************
* Name: Greg Arnold
* Date: 11/7/2023
* Assignment CIS317 Week 1 GP - Composition
*
*This class represents a Student object, which includes the
*student's Name, Major, and GPA. A constructor is provided to set 
*all Students properties. The ToString method is overridden to 
*provide a formatted string of the class properties.
*
*The Equals method is also overridden to allow us to find a student
*strictly by their name.
*/
public class Student
{
    public string Name { get; set;}
    public string Major {get; set;}
    public double GPA {get; set;}

    public Student(string name, string major, double gpa)
    {
        Name = name;
        Major = major;
        GPA = gpa;
    }

    //Override of the ToString method
    public override string ToString()
    {
        //GPA formatted with 2 digits after the decimal (F2)
        return string.Format("Student: {0}\nMajor: {1}\nGPA: {2:F2}", Name,
            Major, GPA);
    }

    //Override the Equals method - we do this so we can use things like a list
    //search method to find a student by name only
    public override bool Equals(Object? obj)
    {
        //check for null and compare run-time type
        if ((obj == null) || !this.GetType().Equals(obj.GetType()))
        {
            return false;
        }
        else
        {
            //cast the passed in object as a Student and compare the name
            Student s = (Student)obj;
            return Name == s.Name;
        }
    }

    //Override the GetHashCode method - necessary whenever overriding Equals
    //to avoid a compiler warning
    public override int GetHashCode()
    {
        //We return the hashcode for the name as that's the only field we're
        //caring about in the object Equals override
        return Name.GetHashCode();
    }
}