/************************************************************************
* Name: Greg Arnold
* Date: 11/21/2023
*Assignment: CIS317 Week 3 GP - Abstraction
*
* This class is derived from the Quadrilateral class and provides a 
* concrete implementation of the AreaFormula method and an override 
* of the Area method. The Area method is overridden as the ara of a 
*rhombus is (diag1 * diag2)/2. The base area method is called and 
*divided by 2 to achieve this.
*/
public class Rhombus : Quadrilateral
{
    public Rhombus(string fillColor, string lineColor, double d1, double d2)
        : base(fillColor, lineColor, d1,d2)
        {

        }
        public override string AreaFormula()
        {
            return "One-half Diagonal 1 times Diagonal 2 (d1 x d2)/2.";
        }
        public override double Area()
        {
            return base.Area()/2;
        }
}