public class Dog 

{ 

    public string PetName { get; set; } 
    public string WhelpDate { get; set; } 
    public int Height { get; set; } 
    public int Length { get; set; } 
    public int Weight { get; set; } 
    public string Gender { get; set; } 
    public string Breed { get; set; } 
    public bool TrackChipStatus { get; set; } 
    public string PersonalityType { get; set; } 

      public Dog(string petName, string whelpDate,int height,int length,int weight,string gender,string breed,bool trackChipStatus,string personalityType)
      {
        PetName = petName;
        WhelpDate = whelpDate;
        Height = height;
        Length = length;
        Weight = weight;
        Gender = gender;
        Breed = breed;
        TrackChipStatus = trackChipStatus;
        PersonalityType = personalityType;
      }
       public override string ToString()
    {
            return string.Format(
                "Pet Name: {0}\nWhelp Date(mm/dd/yyyy): {1}\nHeight: {2}\nLength: {3}\nWeight: {4}\nGender: {5}\nBreed: {6}\nMicrochipped?: {7}\nPersonalityType(Describe your dog's dognality in a few words.): {8}\n",
                PetName,WhelpDate,Height,Length,Weight,Gender,Breed,TrackChipStatus,PersonalityType);
    } 
    public void GetDogInfo() 

    { 

        Console.WriteLine("Enter Your Dog's Information:"); 

        PetName = Console.ReadLine(); 

        WhelpDate = Console.ReadLine(); 

        Height = Convert.ToInt32(Console.ReadLine()); 

        Length = Convert.ToInt32(Console.ReadLine()); 

        Weight = Convert.ToInt32(Console.ReadLine()); 
        
        Gender = Convert.ToInt32(Console.ReadLine()); 

        Breed = Console.ReadLine();

        TrackChipStatus = Convert.ToBoolean(Console.ReadLine()); 

        PersonalityType = Console.ReadLine(); 

      

    } 
   
}