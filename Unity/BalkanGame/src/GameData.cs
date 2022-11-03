using System.Collections.Generic;
public class GameData{
    GameInterface display=new GameInterface();
    string playerName;

    List<Team> teams = new List<Team>();

    Team currentTeam;
    Hero currentHero;

    state currentState;
    Team winner;

    
}