/**************************************************************************************88
*Name: Greg Arnold
*Date: 11/25/2023
*Assignment: CIS317 Week3 Performance Assessment - Abstraction

*This is class is derived from the BoardGame class and provides implementations of the Start Game and Start turn methods.
*/

public class Spinner : BoardGame
{

    public Spinner(string name, int numPlayers, int maxMove) : base (name, numPlayers, maxMove)
    {

    }
  
     public override string StartGame()
    {
        return
        "all the players spin the spinner. The player who spins '1' first goes first.\n";
    }
     public override string StartTurn()
    {
        return
        "the player spins the spinner to determine where to move on the board.\n";
    }
}