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

    public int SharersID { get; set; } 

  

    public void GetShareeInfo() 

    { 

        Console.WriteLine("Enter Sharee Information:"); 

        FName = Console.ReadLine(); 

        LName = Console.ReadLine(); 

        Dob = Console.ReadLine(); 

        Age = Convert.ToInt32(Console.ReadLine()); 

        PhNum = Convert.ToInt32(Console.ReadLine()); 

        Gender = Console.ReadLine(); 

        Email = Console.ReadLine(); 

        Address = Console.ReadLine(); 

        SharersID = Convert.ToInt32(Console.ReadLine()); 

    } 

} 

  