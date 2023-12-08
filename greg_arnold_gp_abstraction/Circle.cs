/************************************************************************
* Name: Greg Arnold
* Date: 11/21/2023
*Assignment: CIS317 Week 3 GP - Abstraction
*
*This class is derived from the Shape class and provides concrete 
*implementations of the AreaFormula and Area methods.
*/
public class Circle : Shape
{
    public double Radius {get;set;}
    public Circle(string fillColor, string lineColor, double radius)
        : base (fillColor, lineColor)
        {
            Radius = radius;
        }
        public override string AreaFormula()
        {
            return "Pi times the radius squared (π x r2)";
        }
        public override double Area()
        {
            return Math.PI*(Radius * Radius);
        }
}
