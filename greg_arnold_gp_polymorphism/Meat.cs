/**************************************************************************************88
*Name: Greg Arnold
*Date: 11/14/2023
*Assignment: CIS317 Week 2 GP Polymorphism
*
*Derived from the Food class. Override of ToString() provided for 
*formatted output of class information. All properties are public 
*with get and set accessors. Constructor sets all properties to
*provided values.
*/
public class Meat: Food
{
    public string Source {get;set;}
    public Meat(string name, string servingSize,string source)
        :base(name, servingSize)
    {
        Source = source;
    }
    public override string ToString()
    {
        return string.Format(
            "{0}Source Description: {1}\n",
            base.ToString(), Source);
        
    }
}