/************************************************************
* Name: Greg Arnold
* Date: 11/9/2023
* Assignment: CIS317 Week 1 PA - Demonstrating Composition - Building a Car
* This class represents an automobile object.A constructor is provided to set all individual properties. 
*/
using System;
using System.Collections.Generic;

public class Automobile
{
    public string Make { get; set;} 
    public string Model { get; set;} 
    public string Color { get; set;} 
    public string BodyStyle { get; set;}
    public Engine EngineInfo {get; set;}
    public List<Tire> Tires {get;} 

    public Automobile(string make, string model, string color,string bodystyle, Engine engineinfo)
    {
        Make=make;
        Model=model;
        Color=color;
        BodyStyle=bodystyle;
        EngineInfo=engineinfo;
        Tires=new List<Tire>();
    }

    public void AddTires(Tire val)
    {
    Tires.Add(val);
    }
    public void AddTires(string manufac,string size,int maxpress, int minpress,string type)
    {
        Tires.Add(new Tire(manufac,size,maxpress,minpress,type));
    }
    public string GetBasicInfo()
    {
        return string.Format("Make: {0}\nModel: {1}\nColor: {2}\nEngine:\n \tCylinder Count: {3}\n\tFuel Injected? {4}\nNumber of Tires: 5\n",
        Make,Model,Color,EngineInfo.Cylinders, EngineInfo.FuelInjected);
    }
    //Override of the ToString method
    public override string ToString()
    {
        string rval;
        int i = 1;
        rval = string.Format("Make: {0}\nModel: {1}\nColor: {2}\nBody Style: {3}\nEngine Cylinders: {4}\nGas Type: {5}\nFuel Injected? {6}\n",
        Make,Model,Color, BodyStyle, EngineInfo.Cylinders, EngineInfo.GasType,EngineInfo.FuelInjected);
        
        
        foreach (Tire tire in Tires)

        {
            rval += "\nTire "+(i++)+"\n";
            rval += tire;}
        return rval;
    }
}
