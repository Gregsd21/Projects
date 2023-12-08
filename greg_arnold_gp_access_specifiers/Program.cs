/*******************************************************************
* Name: Greg Arnold
* Date: 11/21/2023

* Assignment: CIS317 Week 3 GP – Access Specifiers
*
* Main application class.
*/
public class AccessSpecifiers
{
public static void Main(string[] args)
{
Console.WriteLine("\nGreg Arnold, Week 3 Access Specifiers GP\n");
//Create a Person object
//Note that you cannot create it directly because of the access
//level on the constructor, so you have to instantiate the derived
//class

Person person = new Student("John Smith", 22, "js@mail.com", 2022);
//The following will generate an error
//Person person1 = new Person("John Smith", 22, "js@mail.com");
//print person info using ToString...even though Person doesn't
//actually implement ToString - polymorphism again - we get the
//Student ToString

Console.WriteLine("Person printed using Student's ToString");
Console.WriteLine(person);

//now print the information using the getters - note the Student
//getters aren't available because this is a Person object

Console.WriteLine("Person printed using Person property accessors");
Console.WriteLine("Name: " + person.Name);
Console.WriteLine("Age: " + person.Age);
Console.WriteLine("Email: " + person.Email);

//now let's do the same, only with a Student object direclty

Student student = new Student("Jane Jones", 19, "jj@mail.com", 2023);

//print person info using tostring....even though Person doesn't
//actually implement tostring - polymorphism again - we get the
//Student tostring

Console.WriteLine("\nStudent printed using Student's ToString");
Console.WriteLine(student);

//now update the information for the student

student.UpdateName("Jane Smith-Jones");
student.UpdateAge(21.1);
student.UpdateEmail("jsj@mail.com");
student.UpdateGradYear(2023);

//now print the information using the get accessors
Console.WriteLine("Student printed using Student & Person accessors");
Console.WriteLine("Name: " + student.Name);
Console.WriteLine("Age: " + student.Age);
Console.WriteLine("Email: " + student.Email);
Console.WriteLine("Graduation Year: " + student.GradYear);
}
}
