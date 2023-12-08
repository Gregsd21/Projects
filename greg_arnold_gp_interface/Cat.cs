/************************************************************************
* Name: Greg Arnold
* Date: 11/14/2023
*Assignment: CIS317 Week 2 GP - Interfaces
*
*Cat class implements the IAnimal interface, providing  the required
*overrides of all of IAnimal's methods. Class member variables are
*included to support the interface methods. No additional 
*functionality beyond what the interface requires is provided.
*/
public class Cat : IAnimal
{
    private string m_name;
    public Cat(string name)
    {
        m_name = name;
    }
    public string GetName()
    {
        return m_name;
    }
    public string MakeSound()
    {
        return "Meow Meow Meow Meow";
    }
    public void Move(string start, string end)
    {
        Console.WriteLine("Leaping from " + start + " to " + end);
    }
    public override string ToString()
    {
        return string.Format(
            "Cat Information:\nName: {0}\n", m_name);
    }

}