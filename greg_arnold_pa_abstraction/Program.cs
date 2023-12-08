/**************************************************************************************88
*Name: Greg Arnold
*Date: 11/25/2023
*Assignment: CIS317 Week3 Performance Assessment - Abstraction

*This is the application class.
*/

public class GameOn
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nGreg Arnold - Week 3 Abstraction Performance Assessment\n");
        
        Console.WriteLine("Card Game Information");
        CardGame cardGame = new CardGame("Uno", 4, 7);
        Console.WriteLine(cardGame);

        Console.WriteLine("Board Game with Dice Game Information");
        Dice diceGame = new Dice("Candy Land", 3, 5);
        Console.WriteLine(diceGame);

        Console.WriteLine("Board Game with Spinner Game Information");
        Spinner spinnerGame = new Spinner("Twister", 2, 8);
        Console.WriteLine(spinnerGame);

       // CardGame cardGame = new CardGame("Spades", 8);
        //Console.WriteLine(game);

    }
}