public class Dog 

{ 

    public string PetName { get; set; } 

    public string WhelpDate { get; set; } 

    public int DogAge { get; set; } 

    public int Height { get; set; } 

    public int Length { get; set; } 

    public int Weight { get; set; } 

    public string Breed { get; set; } 

    public bool AKCStatus { get; set; } 

    public bool CKCStatus { get; set; } 

    public bool TrackChipStatus { get; set; } 

    public string PersonalityType { get; set; } 

    public string EnergyLevel { get; set; } 

  

    public void GetDogInfo() 

    { 

        Console.WriteLine("Enter Dog Information:"); 

        PetName = Console.ReadLine(); 

        WhelpDate = Console.ReadLine(); 

        DogAge = Convert.ToInt32(Console.ReadLine()); 

        Height = Convert.ToInt32(Console.ReadLine()); 

        Length = Convert.ToInt32(Console.ReadLine()); 

        Weight = Convert.ToInt32(Console.ReadLine()); 

        Breed = Console.ReadLine(); 

        AKCStatus = Convert.ToBoolean(Console.ReadLine()); 

        CKCStatus = Convert.ToBoolean(Console.ReadLine()); 

        TrackChipStatus = Convert.ToBoolean(Console.ReadLine()); 

        PersonalityType = Console.ReadLine(); 

        EnergyLevel = Console.ReadLine(); 

    } 

} 