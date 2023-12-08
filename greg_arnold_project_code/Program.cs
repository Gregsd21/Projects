/***************************************************************************
Name: Greg Arnold
Date: 11/26/2023
Assignment: Petshare course project 3.7
* This project is for a pet sharing app.
*/

using System; 
using System.Collections.Generic; 
using System.Data.SQLite;

public class Program 
{ 
   public static void Main(string[] args)
     { 

        WelcomeSignUp welcomeSignUp = new WelcomeSignUp();
        Sharer sharer = new Sharer(); 
        Sharee sharee = new Sharee(); 
        Dog dog = new Dog(); 
        welcomeSignUp.SignUpInfo(); 
        sharer.GetSharerInfo(); 
        sharee.GetShareeInfo(); 
        dog.GetDogInfo(); 

        Console.WriteLine("\nData saved to the database."); 

        const string dbName = "Greg Arnold's PetShare.db";
        Console.WriteLine("\nGreg Arnold, Pet Share Project\n");
        SQLiteConnection conn = SQLiteDatabase.Connect(dbName);

        if (conn != null)
        {
            PersonDb.CreateTable(conn);

            //Create
            PersonDb.AddPerson(conn, new Sharer("Greg", "Arnold", 21));
            PersonDb.AddPerson(conn, new Sharer("John", "Rhodes", 45));
            PersonDb.AddPerson(conn, new Sharee("Solis", "Jones", 24));
            PersonDb.AddPerson(conn, new Sharee("Joe", "Johnson", 61));

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
} 

  



  





  

