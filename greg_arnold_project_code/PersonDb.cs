/****************************************************************
* Name:Greg Arnold
* Date: 12/3/2023
* Assignment: CIS317 Week 4 PA Database 
*Class to handle all interactions with the People table in the 
*database, including creating the table if it doesn't exist and all
*CRUD (Create, Read, Update, Delete) operations on the People table.
*Note that the interactions are all done using standard SQL syntax
*that is then executed by the SQLite library.
*/
using System.Data.SQLite;
public class PersonDb
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
        + "     ,Email varchar(50));\n"
        + "     ,Address varchar(100));\n"
        + "     ,ShareType varchar(50));";

    SQLiteCommand cmd = conn.CreateCommand();
    cmd.CommandText = sql;
    cmd.ExecuteNonQuery();
    }
    public static void AddPerson(SQLiteConnection conn, Person p)
    {
        string sql = string.Format(
            "INSERT INTO People(FName, LName, Dob, Age, PhNum, Gender, Email, Address, ShareType) "
            + "VALUES('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}','{8}')",
            p.FName, p.LName, p.Dob, p.Age, p.PhNum, p.Gender, p.Email,p.Address, p.ShareType);
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
    }
    public static void UpdatePerson(SQLiteConnection conn, Person p)
    {
        string sql = string.Format(
            "UPDATE People SET FName='{0}', LName='{1}', Dob='{2}', Age={3}, PhNum='{4}', Gender='{5}', Email='{6}', Address='{7}',ShareType='{8}')"
            + " WHERE ID={9}", p.FName, p.LName, p.Dob, p.Age, p.PhNum, p.Gender, p.Email, p.Address, p.ShareType, p.ID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public static void DeletePerson(SQLiteConnection conn, int id)
    {
        string sql = string.Format("DELETE from People WHERE ID = {0}", id);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    public static List<Person> GetAllPeople(SQLiteConnection conn)
    {
        List<Person> people = new List<Person>();
        string sql = "SELECT * FROM People";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        SQLiteDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
            people.Add(new Person(
                rdr.GetInt32(0),
                rdr.GetString(1),
                rdr.GetString(2),
                rdr.GetString(3),
                rdr.GetInt32(4),
                rdr.GetString(5),
                rdr.GetString(6),
                rdr.GetString(7),
                rdr.GetString(8),
                rdr.GetString(9)
            ));
        }

        return people;
    }
    public static Person GetPerson(SQLiteConnection conn, int id)
    {
        string sql = string.Format("SELECT * FROM People WHERE ID = {0}", id);

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        SQLiteDataReader rdr = cmd.ExecuteReader();

        if (rdr.Read())
        {
            return new Person(
                rdr.GetInt32(0),
                rdr.GetString(1),
                rdr.GetString(2),
                rdr.GetString(3),
                rdr.GetInt32(4),
                rdr.GetString(5),
                rdr.GetString(6),
                rdr.GetString(7),
                rdr.GetString(8)
            );
        }
        else
        {
            return new Person(-1, string.Empty, string.Empty, -1, string.Empty,string.Empty,string.Empty,string.Empty);
        }
    }
}