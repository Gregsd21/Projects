public class WelcomeSignUp 
{ 
    public string OwnOrRent { get; set; } 

    public WelcomeSignUp(string ownOrRent)
   {
    OwnOrRent = ownOrRent;
   }
    public void SignUpInfo() 
    { 
        bool validInput = false;

        while (!validInput)
        {
        Console.WriteLine("Welcome! Are you a pet owner(Sharer) or renter(Sharee)?:"); 
        string ownOrRent = (Console.ReadLine()); 
        if (string.Equals(ownOrRent, "Sharer", StringComparison.OrdinalIgnoreCase))
        {   Sharer sharer = new Sharer();
            sharer.GetSharerInfo();
            validInput = true;
        }
        else if (string.Equals(ownOrRent, "Sharee", StringComparison.OrdinalIgnoreCase))
        {   Sharee sharee = new Sharee();
            sharee.GetShareeInfo();
            validInput = true;
        }
        else
        {
            Console.WriteLine("Please input Sharer or Sharee for your option.");
        }
        }
    } 

} 

  

