/****************************************************************
* Name:Greg Arnold
* Date: 12/3/2023
* Assignment: CIS317 Week 4 PA Database 
*Class that represents an individual sharer record from the Sharer
*table in the database. Note that the properties are public in this
*case as this class is purely used to hold data from the Sharer
*table.
*/

public class Sharer : Person 

{ 

    public string Address { get; set; } 

    public string DogName { get; set; } 

    public string DogBreed { get; set; } 


public Sharer(string fName, string lName, string dob, int age, string phNum, 
  string gender, string email, string address, string dogName, string dogBreed)
  : base( iD, fName, lName, dob, age, phNum, gender,email)
{
  Address = address;
  DogName = dogName;
  DogBreed = dogBreed;
}
 public override string ToString()
    {
        return string.Format(
            "First Name: {0}\nLast Name: {1}\nDate of Birth (mm/dd/yyyy): {2}\nAge: {3}\nPhone: {4}\nGender: {5}\nEmail: {6}\nAddress: {7}",
            base.ToString(),Address);

} 
    public void GetSharerInfo() 

    { 

        Console.WriteLine("Enter Your Sharer Information:\n"); 

        FName = Console.ReadLine(); 

        LName = Console.ReadLine(); 

        Dob = Console.ReadLine(); 

        Age = Convert.ToInt32(Console.ReadLine()); 

        PhNum = Console.ReadLine(); 

        Gender = Console.ReadLine(); 

        Email = Console.ReadLine(); 

        Address = Console.ReadLine(); 

        
    } 
     
}