/**************************************************************************************88
*Name: Greg Arnold
*Date: 11/25/2023
*Assignment: CIS317 Week3 Performance Assessment - Abstraction

*This is class is derived from the BoardGame class and provides implementations of the Start Game and Start turn methods.
*/

public class Dice : BoardGame
{
  public Dice(string name, int numPlayers, int maxMove) : base (name, numPlayers, maxMove)
  {

  }
     public override string StartGame()
    {
        return
        "all the players select a board piece avatar.\n";
    }
     public override string StartTurn()
    {
        return
        "player must flip a coin to determine if they get one or two rolls of the dice.\n";
    }

}