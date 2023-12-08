/******************************************************************************************
* Name: Greg Arnold
* Date: 11/30/2023
*Assignment: CIS317 Week 4 GP - Database Interactions
* 
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
        //SQL statement for creating a new table
        string sql = 
            "CREATE TABLE IF NOT EXISTS People (\n"
            + "   ID integer PRIMARY KEY\n"
            + "   ,FirstName varchar(20)\n"
            + "   ,LastName varchar(40)\n"
            + "   ,Age integer);";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void AddPerson(SQLiteConnection conn, Person p)
    {
        string sql = string.Format(
            "INSERT INTO People(FirstName, LastName, Age) "
            + "VALUES('{0}','{1}',{2})",
            p.FirstName, p.LastName, p.Age);
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
    }
    public static void UpdatePerson(SQLiteConnection conn, Person p)
    {
        string sql = string.Format(
            "UPDATE People SET FirstName='{0}', LastName='{1}', Age={2}"
            + " WHERE ID={3}", p.FirstName, p.LastName, p.Age, p.ID);
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
                rdr.GetInt32(3)
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
                rdr.GetInt32(3)
            );
        }
        else
        {
            return new Person(-1, string.Empty, string.Empty, -1);
        }
    }
}