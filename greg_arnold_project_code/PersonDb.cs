/****************************************************************
* Name:Greg Arnold
* Date: 12/3/2023
* Assignment: CIS317 Week 4 PA Database 
* This class will provide a means for database interaction with the Person table.
*/
using System.Data.SQLite;
public class PersonDb
{
    public static void CreateTable(SQLiteConnection conn)
    {
        //Default statement to create a new table
        string sql =
        "CREATE TABLE IF NOT EXISTS Addresses (\n"
        + "     ID integer PRIMARY KEY\n"
        + "     ,FName varchar(50)\n"
        + "     ,LName varchar(50)\n"
        + "     ,Dob varchar(50)\n"
        + "     ,Age integer\n"
        + "     ,PhNum varchar(50)\n"
        + "     ,Gender varchar(50)\n"
        + "     ,Email varchar(50));";

    SQLiteCommand cmd = conn.CreateCommand();
    cmd.CommandText = sql;
    cmd.ExecuteNonQuery();
    }
    public static void AddPerson(SQLiteConnection conn, Person p)
    {
        string sql = string.Format(
            "INSERT INTO People(FName, LastName, Dob, Age, PhNum, Gender, Email) "
            + "VALUES('{0}','{1}','{2}',{3},'{4}','{5}','{6}')",
            p.FirstName, p.LastName, p.Dob, p.Age, p.PhNum, p.Gender, p.Email);
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
    }
    public static void UpdatePerson(SQLiteConnection conn, Person p)
    {
        string sql = string.Format(
            "UPDATE People SET FirstName='{0}', LastName='{1}', Dob='{2}', Age={3}, PhNum='{4}', Gender='{5}', Email='{6}')"
            + " WHERE ID={7}", p.FirstName, p.LastName, p.Dob, p.Age, p.PhNum, p.Gender, p.Email, p.ID);
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
                rdr.GetString(7)
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
                rdr.GetString(7)
            );
        }
        else
        {
            return new Person(-1, string.Empty, string.Empty, -1);
        }
    }
}