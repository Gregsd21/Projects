/**************************************************************************************88
*Name: Greg Arnold
*Date: 11/14/2023
*Assignment: CIS317 Week 2 GP Polymorphism
*
*Main application class.
*/
public class PolymorphismExample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nGreg Arnold, Week 2 Polymorphism GP\n");

        Food food = new Food("Food Class", "Undefined");
        Vegetable veg = new Vegetable("Romaine Lettuce", "3 cups",
            "Spring", "Summer");
        Corn corn = new Corn("One Ear", "Spring", "Summer/Fall",
            "Silver Queen Sweet", "4 ears per tray");
        Meat meat = new Meat("Angus Beef", "6 oz",
        "Free Range Grass Fed");

        //Note how the List type is "Food", but Polymorphism
        //allows us to add objects of any class derived from food.
        List<Food> foods = new List<Food>();
        foods.Add(food);
        foods.Add(veg);
        foods.Add(corn);
        foods.Add(meat);

        //print the food list using our printFoodInfo function
        Console.WriteLine("Items in foods List:\n");
        foreach (Food f in foods)
        {
            PrintFoodInfo(f);
        }
        //Similar to above example; note that you cannot add an 
        //object of type Food to the list even though Vegetable 
        //is derived from Food and you cannot add an item of type Meat 
        //even though Vegetable and Meat both are derived from Food - only
        //objects of type Vegetable and classes that are derived from 
        //Vegetable (in this case, Corn) can be in the list
        List<Vegetable> veggies =new List<Vegetable>();
        veggies.Add(veg);
        veggies.Add(corn);
        //veggies.Add(food); //compiler error
        //veggies/Add(meat); //compiler error

        //print the vegetable list using our printFoodInfo function
        Console.WriteLine("Items in veggies List:\n");
        foreach (Vegetable v in veggies)
        {
            PrintFoodInfo(v);
        }
    }
    private static void PrintFoodInfo(Food food)
    {
        Console.WriteLine(food.ToString());
    }
}