/**************************************************************************************
*Name: Greg Arnold
*Date: 11/25/2023
*Assignment: CIS317 Week3 Performance Assessment - Constructors and Access Specifiers

*This is the application class.
*/

public class CarType
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Greg Arnold - Week 3 Constructors & Access Specifiers Performance Assessment\n");
        Console.WriteLine("Cars in the parking lot:\n");
        ParkingLot parkingLot = new ParkingLot();

        ElectricCar electricCar = new ElectricCar();
        GasCar gasCarV4 = new GasCar("Unleaded Regular","4-Cylinder");
        GasCar gasCarV6 = new GasCar("Unleaded Premium","V6 DOHC");

        parkingLot.Cars.Add(electricCar);
        parkingLot.Cars.Add(gasCarV4);
        parkingLot.Cars.Add(gasCarV6);
        foreach (var car in parkingLot.Cars)
        {
            Console.WriteLine(car);
        }
    }
}