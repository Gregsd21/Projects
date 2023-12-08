/**************************************************************************************88
*Name: Greg Arnold
*Date: 11/25/2023
*Assignment: CIS317 Week3 Performance Assessment - Abstraction

*This is class is derived from the Game class and provides concrete implementations of the EndTurn method and abstract overrides for Start game and Start turn.
*/
public abstract class BoardGame : Game
{
    public int MaxMove {get;set;}
    public BoardGame(string name, int numPlayers, int maxMove) : base (name, numPlayers)
    {
        MaxMove = maxMove;
    }
   public abstract override string StartGame();
   public abstract override string StartTurn();
    public override string EndTurn()
    {
       return
        "the player moves their piece the appropriate number of spaces.\n";
    }

}