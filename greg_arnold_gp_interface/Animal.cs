/************************************************************************
* Name: Greg Arnold
* Date: 11/14/2023
*Assignment: CIS317 Week 2 GP - Interfaces
*
*Interface class IAnimal - Definess all methods and classes that implement this interface must implement.
*/
interface IAnimal
{
    string GetName();
    string MakeSound();
    void Move(string start, string end);
}