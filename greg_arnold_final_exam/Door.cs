/**********************************************************************
* Name: Greg Arnold
* Date:12/7/2023
* Assignment CIS317 Week 5 Final Practical Exam
*
*This class demonstrates composition and how a Door relates to a House. This class demonstrates PolyMorphism.
*/

public class Door
{
    private int Width {get; set;}
    private string Color {get; set;}

public Door(int width, string color)
{
    Width = width;
    Color = color;
}
//Demonstrates Polymorphism
public override string ToString()
{
     return string.Format(
            "The Door is {0} inches wide and is {1} in color.",
            Width, Color);
}
}