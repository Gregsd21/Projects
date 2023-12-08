/**************************************************************************************88
*Name: Greg Arnold
*Date: 11/25/2023
*Assignment: CIS317 Week3 Performance Assessment - Abstraction

*This is the base class for providing abstract methods for getting Game related information.
*/

public abstract class Game 
{
public string Name { get; set;}
public int NumPlayers { get; set;}

public Game(string name, int numPlayers)
{
    Name = name;
    NumPlayers = numPlayers;
}
public abstract string StartGame();
public abstract string StartTurn();
public abstract string EndTurn();
public override string ToString()
{
    return 
    
    "Welcome to "+ Name + " . We have "+ NumPlayers + " players with us today.\n" +
    "To start the game, "+ StartGame() + 
    "To start a turn," + StartTurn() +
    "The turn is over when "+ EndTurn() + "\n";
}

}