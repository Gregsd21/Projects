/************************************************************************
* Name: Greg Arnold
* Date: 11/21/2023
*Assignment: CIS317 Week 3 GP - Abstraction
*
*This class derived from the Shape class and is also an abstract base 
*class for specific types of Quadrilaterals. The AreaFormula method
*is left abstract because this class will not be able to provide
*that specific information. The class also provides an 
*implementation of the area method as many quadrilaterals calculate
*area as a simple multiplication of two provided measurements (e.g
*square, rectangle, parallellogram). Other classes can override 
*the area method to provide their own functionality. 
*/
public abstract class Quadrilateral : Shape
{
    public double Length1 {get; set;}
    public double Length2 {get; set;}
public Quadrilateral(string fillColor, string lineColor, 
        double length1, double length2) : base(fillColor, lineColor)
{
    Length1 = length1;
    Length2 = length2;
}
public abstract override string AreaFormula();
public override double Area()
{
    return Length1 * Length2;
}
}