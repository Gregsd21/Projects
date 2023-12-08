/**********************************************************************
* Name: Greg Arnold
* Date:12/7/2023
* Assignment CIS317 Week 5 Final Practical Exam
*
*This class demonstrates composition and how a Kitchen relates to a House. This class contains Access Specifiers. 
*/

public class Kitchen
{   //Demonstrates Access Specifiers
    private string Style {get; set;}
    private string ApplianceBrand {get; set;}

public Kitchen(string style, string applianceBrand)
{
    Style = style;
    ApplianceBrand = applianceBrand;
}

public override string ToString()
{
     return string.Format(
            "The kitchen is a {0} styled kitchen with {1} appliances.\n",
            Style, ApplianceBrand);
}
}