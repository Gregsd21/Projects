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
    public string ShareType {get; set;}
//Constructor with ID
public Person(int iD, string fName, string lName, string dob, int age, string phNum, string gender, string email, string shareType)
{
  ID = iD;
  FName = fName;
  LName = lName;
  Dob = dob;
  Age = age;
  PhNum = phNum;
  Gender = gender;
  Email = email;
  ShareType = shareType;
}
/*Constructor with Share Type*/
public Person(string fName, string lName, string dob, int age, string phNum, string gender, string email, string address, string shareType)
{
  FName = fName;
  LName = lName;
  Dob = dob;
  Age = age;
  PhNum = phNum;
  Gender = gender;
  Email = email;
  Address = address;
  ShareType = shareType;
} 
/*Constructor with no ID or Share Type.*/
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

