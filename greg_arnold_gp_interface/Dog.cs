/************************************************************************
* Name: Greg Arnold
* Date: 11/14/2023
*Assignment: CIS317 Week 2 GP - Interfaces
*
* Dog class implements the IAnimal interface, providing the required 
*overrides of all IAnimal's methods. Class member variables are
*included to support the interface methods and a class property
*with get and set accessors is provided for functionality beyond what 
*the interface requires.
*/
public class Dog : IAnimal
{
    private string m_name;
    public string FavoriteActivity {get; set;}
    
    public Dog(string name, string favoriteActivity)
    {
        m_name = name;
        FavoriteActivity = favoriteActivity;
    }
    public string GetName()
    {
        return m_name;
    }
    public string MakeSound()
    {
        return "Bow Wow Wow Woof Woof";
    }
    public void Move(string start, string end)
    {
        Console.WriteLine("Bounding from " + start + " to " + end);
    }
    public override string ToString()
    {return string.Format("Dog Information:\nName: {0}\nFavorite Activity: {1}\n",
        m_name, FavoriteActivity);
    }
}