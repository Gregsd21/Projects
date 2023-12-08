/**********************************************************************
* Name: Greg Arnold
* Date:11/7/2023
* Assignment CIS317 Week 1 GP - Composition
*
*Main application class.
*/
public class CompositionTest
{
    static void Main(string[] args)
    {
        //Create 3 Students for our classrooms
        Student s1 = new Student("John Doe", "Psychology", 3.95);
        Student s2 = new Student("Jane Smith", "Biology", 3.28);
        Student s3 = new Student("Greg Arnold", "Software Development", 4.0);

        //Create 2 CollegeClass objects
        //Add a Professor inline for this one
        CollegeClass class1 = new CollegeClass("ENG123", "Intro to Poetry",
            new Professor("Robert Frost", "Dr.", "English"));
        //Create a Professor to add to the second CollegeClass
        Professor prof = new Professor("James Gosling", "PRofessor", "CIS");
        CollegeClass class2 = new CollegeClass("CIS317", "C# Programming", prof);

        //Add some students to our Poetry class
        class1.AddStudent(s1);
        class1.AddStudent(s2);
        class1.AddStudent(s3);
        class1.AddStudent("Jimmy Smith", "Chemistry", 2.56);
        class1.AddStudent(new Student("Fred Flintstone", "Archeology", 2.3));

        //Add some students to our Java Class
        class2.AddStudent(s3);
        class2.AddStudent("Rasmus Lerdorf", "Web Development", 3.6);
        class2.AddStudent(new Student("Ada Lovelace", "Math", 3.99));

        //Now let's see what we have
        Console.WriteLine("\nGreg Arnold = Composition Guided Practice");
        Console.WriteLine("CollegeClass class1 Unmodified");
        Console.Write(class1.GetInfo());

        Console.WriteLine("\nCollegeClass class2 Unmodified");
        Console.Write(class2.GetInfo());

        class1.RemoveStudent("Fred Flintstone");
        Console.WriteLine("\nCollegeClass class1 After Removing Fred");
        Console.Write(class1.GetInfo());

        Console.WriteLine("\nExamples of class objects using tostring");
        Console.Write("CollegeClass object: ");
        Console.WriteLine(class1);
        Console.Write("Professor object: ");
        Console.WriteLine(prof);
        Console.WriteLine("Student object:");
        Console.WriteLine(s3);
    }
}