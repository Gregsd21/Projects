/************************************************************************
* Name: Greg Arnold
* Date: 11/14/2023
*Assignment: CIS317 Week 2 GP - Interfaces
*
*Main application class.
*/
public class InterfaceExample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nGreg Arnold, Week 2 Interface GP\n");
        //IAnimal animal = new IAnimal(); //error - cannot instantiate
    

    Dog dog1 = new Dog("Fido", "Chasing squirresl");
    Dog dog2 = new Dog("Rex", "Sleeping in the sun");
    Cat cat1 = new Cat("Felix");
    Cat cat2 = new Cat("Garfield");

    List<IAnimal> animals = new List<IAnimal> {dog1, dog2, cat1, cat2 };
    Console.WriteLine("Animals printed from List");
    foreach (IAnimal animal in animals)
    {
        PrintAnimal(animal);
        Console.WriteLine();
    }
    Console.WriteLine("Animals printed directly");
    PrintAnimal(dog1);
    dog1.Move("porch", "yard");

    Console.WriteLine();
    PrintAnimal(dog2);
    dog2.Move("floor", "bed");

    Console.WriteLine();
    PrintAnimal(cat1);
    cat1.Move("window sill", "kitchen counter");

    Console.WriteLine();
    PrintAnimal(cat2);
    cat2.Move("back of the sofa", "laundry basket");
    Console.WriteLine();
}
private static void PrintAnimal(IAnimal animal)
{
    Console.Write(animal);
    Console.Write("Says: " + animal.MakeSound() + "\n");
}
}