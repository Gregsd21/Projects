/****************************************************************
* Name:Greg Arnold
* Date: 12/3/2023
* Assignment: CIS317 Week 4 PA Database 
*Class that represents an individual sharee record from the Sharee
*table in the database. Note that the properties are public in this
*case as this class is purely used to hold data from the Sharee
*table.
*/


public class Sharee : Person 

{ 

    public string Address { get; set; } 

    public Sharee(string fName, string lName, string dob, int age, string phNum, string gender, string email, string shareType, string address)
    : base(fName, lName, dob, age, phNum, gender, email, shareType)
    {
    Address = address;
    } 
        public override string ToString()
    {
        return string.Format(
            "First Name: {0}\nLast Name: {1}\nDate of Birth (mm/dd/yyyy): {2}\nAge: {3}\nPhone: {4}\nGender: {5}\nEmail: {6}\nAddress: {7}",
            base.ToString(),Address);
    }
    public void GetShareeInfo() 

    { 

        Console.WriteLine("Enter Your Sharee Information:\n");

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

  