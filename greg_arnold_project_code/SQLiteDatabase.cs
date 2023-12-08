/**************************************************************
* Name:Greg Arnold
* Date: 12/5/2023
* Assignment: CIS317 Week 4 Database Implementation 
* This class will connect our program SQLite Database.
*/
using System.Data.SQLite;

public class SQLiteDatabase
{
    public static SQLiteConnection Connect(string database)
    {
        string cs = @"Data Source=" + database;
        SQLiteConnection conn = new SQLiteConnection(cs);

        try
        {
            conn.Open();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return conn;
    }
}