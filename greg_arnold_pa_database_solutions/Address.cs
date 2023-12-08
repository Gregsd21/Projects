/**************************************************************
* Name:Greg Arnold
* Date: 12/3/2023
* Assignment: CIS317 Week 4 PA Database 
* This class represents a record from the address table.
*/
public class Address
{
    public int ID {get; set;}
    public string StreetAddress1 {get; set;}
    public string StreetAddress2 {get; set;}
    public string City {get; set;}
    public string State {get; set;}
    public int ZipCode {get; set;}

public Address(int iD, string streetAddress1, string streetAddress2, string city, string state, int zipCode)
{
  ID = iD;
  StreetAddress1 = streetAddress1;
  StreetAddress2 = streetAddress2;
  City = city;
  State = state;
  ZipCode = zipCode;
}
public Address(string streetAddress1, string streetAddress2, string city, string state, int zipCode)
{
  StreetAddress1 = streetAddress1;
  StreetAddress2 = streetAddress2;
  City = city;
  State = state;
  ZipCode = zipCode;
}
}