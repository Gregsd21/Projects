/******************************************************************************************
* Name: Greg Arnold
* Date: 11/30/2023
*Assignment: CIS317 Week 4 GP - Database Interactions
* 
*Mainapplication class.
*/
using System.Data.SQLite;

public class DBExample
{
    public static void Main(string[] args)
    {
        const string dbName = "Greg Arnold.db";
        Console.WriteLine("\nGreg Arnold, Week 4 Database Interactions GP\n");
        SQLiteConnection conn = SQLiteDatabase.Connect(dbName);

        if (conn != null)
        {
            PersonDb.CreateTable(conn);

            //Create
            PersonDb.AddPerson(conn, new Person("Greg", "Arnold", 21));
            PersonDb.AddPerson(conn, new Person("John", "Smith", 45));
            PersonDb.AddPerson(conn, new Person("Jane", "Jones", 24));
            PersonDb.AddPerson(conn, new Person("Joe", "Diffy", 61));

            //Read
            Console.WriteLine("\nAll People in the Database");
            PrintPeople(PersonDb.GetAllPeople(conn));
            Console.WriteLine("\nGet a Person Using an Invalid ID");
            PrintPerson(PersonDb.GetPerson(conn, -5));

            //Update
            Person personToUpdate = new Person(2, "James", "Smith", 37);
            PersonDb.UpdatePerson(conn, personToUpdate);
            Person updatedPerson = PersonDb.GetPerson(conn, personToUpdate.ID);
            Console.WriteLine("\nUpdated Person");
            PrintPerson(updatedPerson);

            //Delete
            PersonDb.DeletePerson(conn, personToUpdate.ID);
            Console.WriteLine("\nAll People in the Database");
            PrintPeople(PersonDb.GetAllPeople(conn));
        }
    }

    private static void PrintPeople(List<Person> people)
    {
        foreach (Person p in people)
        {
            PrintPerson(p);
        }
    }
    private static void PrintPerson(Person p)
    {
        Console.WriteLine("Person" + p.ID + ":");
        Console.WriteLine(p.FirstName + " " + p.LastName + " is "
            + p.Age + " years old\n");
    }
}