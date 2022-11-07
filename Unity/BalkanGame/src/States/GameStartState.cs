using System.Diagnostics;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BalkanGame.States;

public class GameStartState : IState
{
    private readonly GameManager game;

    public GameStartState(GameManager game)
    {
        this.game = game;
    }

    GameData gameData = new GameData();
    public void Start()
    {
        game.gameData.playerName = game.gameInterface.EnterName();
        game.gameInterface.WelcomePlayer();
    }
    public void Destroy()
    {
    }
}