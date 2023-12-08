/************************************************************************
* Name: Greg Arnold
* Date: 11/21/2023
*Assignment: CIS317 Week 3 GP - Abstraction
*
* Main application class.
*/
public class AbstractionTest
{
    public static void Main(string[] args)
    {
    Console.WriteLine("\nYour Name, Week 3 Abstraction GP\n");

    //Can't instantiate abstract classes - ucommenting the line
    //below will demonstrate that
    //Shape shape = new Shape(); //ERROR - can't instantiate Shape

    //However, we can declare an object of type Shape and 
    //instantiate it as any of the concrete types...don't
    //forget about polymorphism...let's do this for each 
    //concrete type
    Shape shape = new Square("Orange", "Red", 5.0);
    Console.WriteLine(shape);
    shape = new Rectangle("Green", "Black", 5.5, 2.5);
    Console.WriteLine(shape);
    shape = new Rhombus("Purple", "Red", 1.7, 3);
    Console.WriteLine(shape);
    shape = new Circle("Blue", "Red", 3.4);
    Console.WriteLine(shape);

    //Now lets create the objects directly - recall that only 
    //the Shape class implements ToString, but it's accessible
    //to the derived classes
    Square square = new Square("Chartreuse", "Forest Green", 11.2);
    Console.WriteLine(square);
    Rectangle rect = new Rectangle("Grey", "Gray", 3.2, 5.5);
    Console.WriteLine(rect);
    Rhombus para = new Rhombus("Yellow","Orange", 2.9, 4.7);
    Console.WriteLine(para);
    Circle circle = new Circle("Cyan", "Brown", 1.234);
    Console.WriteLine(circle); 
}
}