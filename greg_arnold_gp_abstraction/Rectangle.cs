/************************************************************************
* Name: Greg Arnold
* Date: 11/21/2023
*Assignment: CIS317 Week 3 GP - Abstraction
*
* This class is derived from the Quadrilateral class and provides a 
*concrete implementation of the AreaFormula method.
*/
public class Rectangle : Quadrilateral
{
    public Rectangle(string fillColor,string lineColor, double length1,
        double length2) : base(fillColor, lineColor, length1, length2)
        {

        }
        public override string AreaFormula()
        {
            return "Lenth times Width (1 x w).";
        }
}