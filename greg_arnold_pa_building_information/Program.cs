/***********************************************************************************************
*Name: Greg Arnold
*Date:11/16/2023
*CIS Performance Assessment- Polymorphism
*This class is the main application
*/

class HousingApp
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Greg Arnold - Week 2 Polymorphism Performance Assessment\n");
        Building building = new Building(15,"123 Main Street","Mirrored Glass");
        Condominium condo = new Condominium(33,"321 Atlantic Avenue","Concrete/Stucco",615);
        House house = new House(1,"23 Apple way", "Brick","Tan",7);
        SplitLevel split1 = new SplitLevel(2,"456 Brittaney Lane","Vinyl Siding","Grey",11,true);
        SplitLevel split2 = new SplitLevel(2,"432 Brittaney Lane","Vinyl Siding","Blue",9,false);

        List<Building> buildings = new List<Building>{building,condo,house,split1,split2};
        List<House> houses = new List<House>{house,split1,split2};
    
       
        Console.WriteLine("Items in buildings ArrayList:\n");
        foreach (Building b in buildings)
        {
            Console.WriteLine(b);
        }
        Console.WriteLine("\nItems in houses ArrayList:\n");
        foreach (House h in houses)
        {
            Console.WriteLine(h);
        }

    }
}