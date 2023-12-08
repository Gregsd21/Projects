/***********************************************************************************************
*Name: Greg Arnold
*Date:11/16/2023
*CIS Performance Assessment- Interface Class- Creating a Vehicle
*This class is the base class Building which all the other classes can inherit its properties via overridingof the ToString().
*/

class HousingApp
{
    static void Main(string[] args)
    {
      Console.WriteLine("Greg Arnold - Week 2 Interface Performance Assessment\n");
      Console.Write("Vehicles Printed from List \n");

      Car c1 = new Car("Ford","Festiva", true, "Miami,FL." );
      Car c2 = new Car("Honda","Accord", false, "Atlanta, GA" );
      CargoTruck ct1 = new CargoTruck("Volvo","VNL 860", false, "150 cubic ft ", "Richmond, VA");
      CargoTruck ct2 = new CargoTruck("Ford","Transit", true, "123 cubic ft ", "Virginia Beach, VA");
      List<IVehicle> cars = new List<IVehicle> {c1,c2,ct1,ct2};
      foreach (IVehicle car in cars)
      {
        PrintCar(car);
        Console.WriteLine();
      }
      Console.Write("Vehicles printed directly \n");
      c1.Start();
      c2.Start();
      ct1.Start();
      ct2.Start();
      ct1.Stop();

      PrintCar(c1);
      Console.Write("\n");
      PrintCar(c2);
      Console.Write("\n");
      PrintCar(ct1);
      Console.Write("\n");
      PrintCar(ct2);
    }
    private static void PrintCar(IVehicle car)
    { 
      Console.Write(car); 
    }
}