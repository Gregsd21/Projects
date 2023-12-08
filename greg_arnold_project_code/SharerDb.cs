/****************************************************************
* Name:Greg Arnold
* Date: 12/3/2023
* Assignment: CIS317 Week 4 PA Database 
* This class will provide a means for database interaction with the Sharer table.
*/
using System.Data.SQLite;
public class SharerDb
{
    public static void CreateTable(SQLiteConnection conn)
    {
        /*Default statement to create a new table*/
        string sql =
        "CREATE TABLE IF NOT EXISTS Addresses (\n"
        + "     ID integer PRIMARY KEY\n"
        + "     ,FName varchar(50)\n"
        + "     ,LName varchar(50)\n"
        + "     ,Dob varchar(50)\n"
        + "     ,Age integer\n"
        + "     ,PhNum varchar(50)\n"
        + "     ,Gender varchar(50)\n"
        + "     ,Email varchar(50))\n"
        + "     ,Address varchar(100);";
       

    SQLiteCommand cmd = conn.CreateCommand();
    cmd.CommandText = sql;
    cmd.ExecuteNonQuery();
    }
    public static void AddSharer(SQLiteConnection conn, Sharer r)
    {
        string sql = string.Format(
            "INSERT INTO Sharers(FName, LName, Dob, Age, PhNum, Gender, Email, Address) "
            + "VALUES('{0}','{1}','{2}',{3},'{4}','{5}','{6}')",
            r.FName, r.LName, r.Dob, r.Age, r.PhNum, r.Gender, r.Email, r.Address);
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
    }
    public static void UpdateSharer(SQLiteConnection conn, Sharer r)
    {
        string sql = string.Format(
            "UPDATE Sharees SET FName='{0}', LName='{1}', Dob='{2}', Age={3}, PhNum='{4}', Gender='{5}', Email='{6}', ShareType='{7}')"
            + " WHERE ID={8}", r.FName, r.LName, r.Dob, r.Age, r.PhNum, r.Gender, r.Email, r.ShareType, r.ID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public static void DeleteSharer(SQLiteConnection conn, int id)
    {
        string sql = string.Format("DELETE from Sharers WHERE ID = {0}", iD);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public static List<Sharer> GetAllSharers(SQLiteConnection conn)
    {
        List<Sharer> sharers = new List<Sharer>();
        string sql = "SELECT * FROM Sharers";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        SQLiteDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
            people.Add(new Sharer(
                rdr.GetInt32(0),
                rdr.GetString(1),
                rdr.GetString(2),
                rdr.GetString(3),
                rdr.GetInt32(4),
                rdr.GetString(5),
                rdr.GetString(6),
                rdr.GetString(7),
                rdr.GetString(8)
            ));
        }

        return sharers;
    }
    public static Sharer GetSharer(SQLiteConnection conn, int id)
    {
        string sql = string.Format("SELECT * FROM Sharers WHERE ID = {0}", id);

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        SQLiteDataReader rdr = cmd.ExecuteReader();

        if (rdr.Read())
        {
            return new Sharer(
                 rdr.GetInt32(0),
                rdr.GetString(1),
                rdr.GetString(2),
                rdr.GetString(3),
                rdr.GetInt32(4),
                rdr.GetString(5),
                rdr.GetString(6),
                rdr.GetString(7)
            );
        }
        else
        {
            return new Sharer(-1, string.Empty, string.Empty, -1, string.Empty,string.Empty,string.Empty,string.Empty);
        }
    }
}