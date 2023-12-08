public class WelcomeSignUp 
{ 
    public bool OwnOrRent { get; set; } 

    public WelcomeSignUp(bool ownOrRent)
   {
    OwnOrRent = ownOrRent;
   }
    public void SignUpInfo() 
    { 
        Console.WriteLine("Welcome! Are you a pet owner(Sharer) or renter(Sharee)?:"); 
        OwnOrRent = Convert.ToBoolean(Console.ReadLine()); 
    } 

} 

  

