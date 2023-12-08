/******************************************************************************************
* Name: Greg Arnold
* Date: 11/30/2023
*Assignment: CIS317 Week 4 GP - Database Interactions
* 
*Class that represents an individual person record from the Persons
*table in the database. Note that the properties are public in this
*case as this class is purely used to hold data from the Persons
*table.
*/
public class Person {
    public int ID {get; set; }
    public string FirstName {get; set; }
    public string LastName {get; set; }
    public int Age {get; set; }

    public Person(int iD, string firstName, string lastName, int age){
        ID = iD;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public Person(string firstName, string lastName, int age){
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

}