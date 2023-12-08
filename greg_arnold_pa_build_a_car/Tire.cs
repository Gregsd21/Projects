/************************************************************
* Name: Greg Arnold
* Date: 11/9/2023
* Assignment: CIS317 Week 1 PA - Demonstrating Composition - Building a Car
*This class represents a Tire object. A constructor is provided to set 
*all Tire properties.The ToString method is overridden
*to provide a formatted string of the class properties.
*/
using System;
using System.Collections.Generic;
public class Tire
{
    public string Manufac { get; set;} 
    public string Size {get; set;} 
    public int Maxpress {get; set;}
    public int Minpress {get; set;}
    public string Type {get; set;} 

public Tire(string manufac,string size,int maxpress, int minpress,string type)
    {
        
        Manufac = manufac;
        Size = size;
        Maxpress = maxpress;
        Minpress = minpress;
        Type = type;
    }      
    public override string ToString()
    {
        return string.Format("     Mfg: {0}\n     Size: {1}\n     Max Pressure: {2}\n     Min Pressure: {3}\n     Type: {4}",Manufac, Size,Maxpress,Minpress,Type);
    }
}
