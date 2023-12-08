/**************************************************************************
* Name: Greg Arnold
* Date:11/21/2023
* Assignment: CIS317 Week 3 GP – Access Specifiers
*
* This class demonstrates using public, private, and protected access
*  specifiers.Of note, the protected constructor means that this
* class cannot be instantiated directly - only a subclass can call
* this class's constructor.The class properties are public, and the
* get accessors provide public access.The set accessors are protected,
* so are only available to subclasses of this class.
*/
public class Person
{
public string Name { get; protected set; }
public double Age { get; protected set; }
public string Email { get; protected set; }
//protected constructor
protected Person(string name, double age, string email)
{
Name = name;
Age = age;
Email = email;
}
}

