/************************************************************
* Name: Greg Arnold
* Date: 11/9/2023
* Assignment: CIS317 Week 1 PA - Demonstrating Composition - Building a Car
* This is the application class.
*/
using System;
using System.Collections.Generic;
public class BuildCar
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Greg Arnold - Week 1 Composition Performance Assessment\n");


        Automobile c1 = new Automobile("BMW","325i","Black","Luxury Sedan",
        new Engine(6,"Premium Unleaded Only",true));
        Automobile c2 = new Automobile("Toyota","4-Runner","Red","SUV",new Engine(6,"Unleaded",true));
       

      
        Tire t1 = new Tire("Pirelli","205/55R16",35,30,"All Season Plus\n\n");
        Tire t2 = new Tire("Falken","205/55R16",35,30,"All Season\n\n");
        Tire t3 = new Tire("Dorman","135/80R17",65,55,"Spare");
        Tire t4 = new Tire("Bridgestone","265/70R17",44,40,"All Terrain\n");
        Tire t5 = new Tire("Cooper","265/70R17",44,40,"Full-Size Spare\n");
        c1.AddTires(t1);
        c1.AddTires(t1);
        c1.AddTires(t2);
        c1.AddTires(t2);
        c1.AddTires(t3);
        Console.WriteLine("Automobile 1 - Using ToString()");
        Console.Write(c1.ToString());
        Console.Write("\n\nAutomobile 2 - Uising GetBasicInfo()\n");
        Console.Write(c2.GetBasicInfo());
        Console.Write("\n\nAutomobile 2 - Using Properties Directly\n");
        Console.Write(c2);
        Console.Write("Tire #1\n"+t4+"\n");
        Console.Write("Tire #2\n"+t4+"\n");
        Console.Write("Tire #3\n"+t4+"\n");
        Console.Write("Tire #4\n"+t4+"\n");
        Console.Write("Tire #5\n"+t5+"\n");
        //Console.Write(c1.GetBasicInfo());
        
       
        }
        
        /*Automobile c2 =new Automobile("Toyota","4-Runner","Red","SUV",6,"Unleaded",true);
        Automobile c2specs = new Automobile("Toyota","4-Runner","Red",EngineInfo.Cylinders,EngineInfo.FuelInjected,TireCount);
        
         Automobile c2specs = new Automobile("Toyota","4-Runner","Red",new Engine(6,true));
        Console.WriteLine(c2specs);
         
        Tires t1 = new Tires("Pirelli","205/55R16",35,30,"All Season Plus\n");
        Tires t2 = new Tires("Falklen","205/R55R16",35,30,"All Season\n");
        Tires t3 = new Tires("Dorman","135/80R17",65,55,"Spare\n");
        Tires t4 = new Tires("Bridgestone","265/70R17",40,44,"All Terrain\n");
        Tires t5 = new Tires("Cooper","265/70R17",40,44,"Full-Size Spare\n");
        Console.WriteLine("Automobile 2 - Using GetBasicInfo()\n"+c2specs.GetBasicInfo());
        Console.Write("Automobile 2 - Using Properties Directly\n");
        Console.WriteLine("Make: {0}\nModel: {1}\nColor: {2}\n Body Style: {3}\nEngine Cylinders: {4}\nGas Type: {5}\nFuel Injected? {6}\n",c2);
        Console.Write("Tire #1\n");
        Console.WriteLine("Manufacturer: {0}\nSize: {1}\nMin Pressure: {2}\nMax Pressure: {3}\nType: {4}",t4);
        Console.Write("Tire #2\n");
        Console.WriteLine("Manufacturer: {0}\nSize: {1}\nMin Pressure: {2}\nMax Pressure: {3}\nType: {4}",t4);
        Console.Write("Tire #3\n");
        Console.WriteLine("Manufacturer: {0}\nSize: {1}\nMin Pressure: {2}\nMax Pressure: {3}\nType: {4}",t4);
        Console.Write("Tire #4\n");
        Console.WriteLine("Manufacturer: {0}\nSize: {1}\nMin Pressure: {2}\nMax Pressure: {3}\nType: {4}",t4);
        Console.Write("Tire #5\n");
        Console.WriteLine("Manufacturer: {0}\nSize: {1}\nMin Pressure: {2}\nMax Pressure: {3}\nType: {4}",t5);
    
    }

       /* public override string ToString()
        {
            return "Automobile 1 - Using ToString()"+c1+t1+t1+t2+t2+t3;
        }
     */
}
