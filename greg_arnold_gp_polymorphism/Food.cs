/**************************************************************************************88
*Name: Greg Arnold
*Date: 11/14/2023
*Assignment: CIS317 Week 2 GP Polymorphism

*The ultimate base class in this example. Override of ToString()
*Provide for formatted output of class information. All properties 
*are public with get and set accessors. 

*Constructor sets all properties to provide values.
*/
public class Food
{
    public string Name {get;set;}
    public string ServingSize {get;set;}

    public Food(string name, string servingSize)
    {
        Name = name;
        ServingSize = servingSize;
    }
    public override string ToString()
    {
        return string.Format(
            "Class Name (Object Type): {0}\n"
            + "Food Name: {1}\nServing Size: {2}\n",
            this.GetType().Name, Name, ServingSize);
        
    }
}