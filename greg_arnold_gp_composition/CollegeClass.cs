/**********************************************************************
* Name: Greg Arnold
* Date:11/7/2023
* Assignment CIS317 Week 1 GP - Composition
*
*This class represents a college class object, which includes the 
* class ID, subject, instructor, and class roster. A constructor is
*provided to set all individual properties. The roster is 
*initialized to an empty list in the constructor and Add and Remove
*methods are provided to modify the class roster.
*
*The ToString method is NOT overridden; however, a GetInfo method
*is included to provide a formatted string of the class properties.
*/

public class CollegeClass
{
    public string ClassId { get; set;}
    public string Subject { get; set;}
    public Professor Instructor { get; set;}
    public List<Student> Roster {get; }

    public CollegeClass(string id, string subj, Professor instructor)
    {
        ClassId = id;
        Subject = subj;
        Instructor = instructor;
        Roster = new List<Student>();
    }

    //Add a student using a Student object
    public void AddStudent(Student val)
    {
        Roster.Add(val);
    }

    //Add a student by creating one based on parameters
    public void AddStudent(string name, string major, double gpa)
    {
        Roster.Add(new Student(name, major, gpa));
    }
    //Remove any students from the roster that match the provided name
    public void RemoveStudent(string name)
    {
        Roster.Remove(new Student(name, "", 0.0));
    }

    private string FormatInstructor()
    {
        return string.Format("Instructor: {0} {1} from the {2} department. \n",
            Instructor.Title, Instructor.Name, Instructor.Department);
    }

    public string GetInfo()
    {
        string rval;
        rval = string.Format("Class ID: {0}\nSubject: {1}\n{2}{3}",
            ClassId, Subject, "------------------------------------\n",
            FormatInstructor());

        //loop over roster to print
        rval += "\nCourse Roster:\n";
        foreach (Student student in Roster)
        {
            rval += student + "\n";
        }

        return rval;
    }
}