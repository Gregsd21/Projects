/**********************************************************************
* Name: Greg Arnold
* Date:11/7/2023
* Assignment CIS317 Week 1 GP - Composition
*
*This class represents a Professor object, which includes the 
*professor's Name, Title, and Department. A constructor is provided
*to set all Professor properties. The ToString is NOT overridden - 
*classes using this class will have to provide their own format using
*the class property get methods.
*/
public class Professor
{
    public string Name {get; set;}
    public string Title {get; set;}
    public string Department {get; set;}  

    public Professor(string name, string title, string dept)
    {
        Name = name;
        Title = title;
        Department = dept;
    }      
}