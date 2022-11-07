using System.Collections.Generic;
using BalkanGame;
using BalkanGame.States;

public class GameData
{
    public string playerName;

    public List<Team> teams = new List<Team>();

    public Team currentTeam;
    public Hero currentHero;

    public IState currentState;
    public Team winner;


}