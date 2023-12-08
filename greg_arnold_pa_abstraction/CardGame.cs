/**************************************************************************************88
*Name: Greg Arnold
*Date: 11/25/2023
*Assignment: CIS317 Week3 Performance Assessment - Abstraction

*This is class is derived from the Game class and provides implementations of all 3 methods.
*/
public class CardGame : Game
{
    public int NumCards {get;set;}
    public CardGame(string name, int numPlayers, int numCards) : base (name, numPlayers)
    {
        NumCards = numCards;
    }
    public override string StartGame()
    {
        return
        "the dealer deals each player 7 cards.\n";
    }
     public override string StartTurn()
    {
        return
        "the player to the dealers left draws or plays a card.\n";
    }
   public override string EndTurn()
    {
        return
        "the player places their card down onto the play deck.\n";
    }
}