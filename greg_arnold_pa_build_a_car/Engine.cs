/************************************************************
* Name: Greg Arnold
* Date: 11/9/2023
* Assignment: CIS317 Week 1 PA - Demonstrating Composition - Building a Car
*This class represents an Engine object. A constructor is provided to set 
*all Engine properties.
*/
using System;
using System.Collections.Generic;
public class Engine
{
    public int Cylinders {get; set;}
    public string GasType {get; set;} 
    public bool FuelInjected {get; set;} 

    public Engine(int cylinders, string gastype, bool fuelinjected) 
    {
        Cylinders=cylinders;
        GasType=gastype;
        FuelInjected=fuelinjected;
    }


       
}