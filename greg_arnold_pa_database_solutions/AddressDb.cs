/****************************************************************
* Name:Greg Arnold
* Date: 12/3/2023
* Assignment: CIS317 Week 4 PA Database 
* This class will provide a means for database interaction with the Address table.
*/
using System.Data.SQLite;
public class AddressDb
{
    public static void CreateTable(SQLiteConnection conn)
    {
        //Default statement to create a new table
        string sql =
        "CREATE TABLE IF NOT EXISTS Addresses (\n"
        + "     ID integer PRIMARY KEY\n"
        + "     ,StreetAddress1 varchar(50)\n"
        + "     ,StreetAddress2 varchar(50)\n"
        + "     ,City varchar(50)\n"
        + "     ,State varchar(50)\n"
        + "     ,ZipCode integer);";

    SQLiteCommand cmd = conn.CreateCommand();
    cmd.CommandText = sql;
    cmd.ExecuteNonQuery();
    }
    public static void AddAddress(SQLiteConnection conn, Address addr)
    {
        string sql = string.Format(
        "INSERT INTO Addresses(StreetAddress1, StreetAddress2, City, State, ZipCode) "
        + "VALUES('{0}','{1}','{2}','{3}',{4})", addr.StreetAddress1, addr.StreetAddress2, addr.City, addr.State, addr.ZipCode);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public static void UpdateAddress(SQLiteConnection conn, Address addr)
    {
         string sql = string.Format( "UPDATE Addresses SET StreetAddress1 = '{0}', StreetAddress2 = '{1}', City = '{2}',"
         + " State = '{3}', ZipCode = {4} WHERE ID = {5}", addr.StreetAddress1, addr.StreetAddress2, addr.City, addr.State, addr.ID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public static void DeleteAddress(SQLiteConnection conn, int id)
    {
        string sql = string.Format("DELETE from Addresses WHERE ID = {0}", id);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public static List<Address> GetAllAddresses(SQLiteConnection conn)
    {
        List<Address> addresses = new List<Address>();
        string sql = "SELECT * FROM Addresses";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        SQLiteDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
            addresses.Add(new Address(
                rdr.GetInt32(0),
                rdr.GetString(1),
                rdr.GetString(2),
                rdr.GetString(3),
                rdr.GetString(4),
                rdr.GetInt32(5)
            ));
        }
        return addresses;
    }
    public static Address GetAddress(SQLiteConnection conn, int id)
    {
        string sql = string.Format("SELECT * FROM Address WHERE ID = {0}", id);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        SQLiteDataReader rdr = cmd.ExecuteReader();

        if (rdr.Read())
        {
            return new Address(
                rdr.GetInt32(0),
                rdr.GetString(1),
                rdr.GetString(2),
                rdr.GetString(3),
                rdr.GetString(4),
                rdr.GetInt32(5)
            );
        }
        else
        {
            return new Address(-1, string.Empty, string.Empty, string.Empty, string.Empty, -1);
        }
        
    }

}