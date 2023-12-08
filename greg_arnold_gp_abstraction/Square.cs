/************************************************************************
* Name: Greg Arnold
* Date: 11/21/2023
*Assignment: CIS317 Week 3 GP - Abstraction
*
* This class is derived from the Quadrilateral class and provides a 
*concrete implementation of the AreaFormula method. Note that as a 
*Square only needs one length only one length is required in the 
*constructor and is passed as both lengths to the base constructor.
*/
public class Square : Quadrilateral
{
    public Square(string fillColor, string lineColor, double length)
            : base(fillColor,lineColor,length, length)
            {

            }
            public override string AreaFormula()
            {
                return "Length squared (12).";
            }
}