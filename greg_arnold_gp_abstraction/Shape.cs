/************************************************************************
* Name: Greg Arnold
* Date: 11/21/2023
*Assignment: CIS317 Week 3 GP - Abstraction
*
*This class is the ultimate base class in this example and provides 
*abstract methods for getting a shape's area and area formula. The 
*class also provides a constructor for use by child classes and 
*provides an override of ToString() for formatted shape information. 
*/
public abstract class Shape
{
    public string FillColor {get; set;}
    public string LineColor {get; set;}
    public Shape(string fillColor, string lineColor)
    {
        FillColor = fillColor;
        LineColor = lineColor;
    }
    public abstract string AreaFormula();
    public abstract double Area();
    public override string ToString()
    {
        return
            "Shape's Properties:\n" +
            "  Type: " + this.GetType().Name + "\n" +
            "  Area Formula: " + AreaFormula() + "\n" +
            "  Area: " + string.Format("{0:F3}", Area()) + "\n" +
            "  Fill Color: " + FillColor + "\n" +
            "  Line Color: " + LineColor + "\n";
    }
}