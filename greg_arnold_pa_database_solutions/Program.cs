/****************************************************************
* Name:Greg Arnold
* Date: 12/3/2023
* Assignment: CIS317 Week 4 PA Database 
* Main Application class
*/
using System.Data.SQLite;
public class DBApp
{
    public static void Main(string[] args)
    {
        const string dbName = "Greg Arnold.db";
        Console.WriteLine("\nGreg Arnold, Week 4 Database Performance Assessment\n");
        SQLiteConnection conn = SQLiteDatabase.Connect(dbName);

        if(conn != null)
        {
            AddressDb.CreateTable(conn);
            //Create
            AddressDb.AddAddress(conn, new Address("123 Apple Tree Ln", "", "Freemont", "NC",23145));
            AddressDb.AddAddress(conn, new Address("321 Labrador Dr", "Apt 5", "Greenville", "VA",54321));
            AddressDb.AddAddress(conn, new Address("916 Spring Grove St", "Unit 3", "Spring", "TX",73915));
            AddressDb.AddAddress(conn, new Address("739 Green Way", "", "Flynt", "MI",28537));
            //Read
            Console.WriteLine("\nAll Addresses in the Database");
            PrintAddresses(AddressDb.GetAllAddresses(conn));
            Console.WriteLine("\nGet an Address Using an Invalid ID");
            PrintAddress(AddressDb.GetAddress(conn, -5));
            //Update
             Address addrToUpdate = new Address(2, "321 Labrador St", "Apt 12", "Greendale", "TN",20194);
             AddressDb.UpdateAddress(conn, addrToUpdate);
             Address updatedAddr = AddressDb.GetAddress(conn, addrToUpdate.ID);
             Console.WriteLine("\nUpdated Address");
             PrintAddress(updatedAddr);
             //Delete
             AddressDb.DeleteAddress(conn, addrToUpdate.ID);
             Console.WriteLine("\nAll Addresses in the Database");
             PrintAddresses(AddressDb.GetAllAddresses(conn));
        }
    }
        private static void PrintAddresses(List<Address> addresses)
        {
            foreach (Address addr in addresses)
            {
                PrintAddress(addr);
            }
        }
        private static void PrintAddress(Address addr)
        {
        Console.WriteLine("Address " + addr.ID + ":");
        Console.WriteLine("  " + addr.StreetAddress1);
        if (addr.StreetAddress2.Length > 0)
        {
            Console.WriteLine("  " + addr.StreetAddress2);
        }
        Console.WriteLine("   " + addr.City + ", " + addr.State + " " + addr.ZipCode);
        
        }
}
