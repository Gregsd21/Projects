/****************************************************************
* Name:Greg Arnold
* Date: 12/3/2023
* Assignment: CIS317 Week 4 PA Database 
*Class that represents an individual person record from the Person
*table in the database. Note that the properties are public in this
*case as this class is purely used to hold data from the Person
*table.
*/
public class Person 

{ 
    public int ID {get; set; }
    public string FName { get; set; } 

    public string LName { get; set; } 

    public string Dob { get; set; } 

    public int Age { get; set; } 

    public string PhNum { get; set; } 

    public string Gender { get; set; } 

    public string Email { get; set; } 

public Person(int iD, string fName, string lName, string dob, int age, string phNum, string gender, string email)
{
  ID = iD;
  FName = fName;
  LName = lName;
  Dob = dob;
  Age = age;
  PhNum = phNum;
  Gender = gender;
  Email = email;
}
public Person(string fName, string lName, string dob, int age, string phNum, string gender, string email)
{
  FName = fName;
  LName = lName;
  Dob = dob;
  Age = age;
  PhNum = phNum;
  Gender = gender;
  Email = email;
} 

}

