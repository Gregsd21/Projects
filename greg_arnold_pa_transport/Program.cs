/************************************************************
* Name: Greg Arnold
* Date: 11/9/2023
* Assignment: CIS317 Week 1 PA - Demonstrating Inheritance - Modes of Transportation
*This class is for my main program application.
*/
public class VehicleIdentify
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nGreg Arnold - Week 1 Inheritance Performance Assessment\n");
        
        Vehicle v = new Vehicle("Red", 3, 2, false);
        Console.WriteLine(v.GetVehicleInfo());

        Bicycle b = new Bicycle("Blue",2,1,true,12,36,18);
        Console.WriteLine(b.GetVehicleInfo());

        Motorized m = new Motorized("Orange",4,2,false,"3.6L V6",true);
        Console.WriteLine(m.GetVehicleInfo());

        Car c2 = new Car("Maroon",4,5,false,"2.4L 4-CYL",false,"None",true);
        Console.WriteLine(c2);

        Truck t = new Truck("Black",6,6,true,"V8 Hemi",false, false, "heavy");
        Console.WriteLine(t);
        
        Car c1 = new Car("Maroon",4,5,false,"2.4L 4-CYL",false,"None",true);
        Console.WriteLine(c1.GetVehicleInfo());
    }
}