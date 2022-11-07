using BalkanGame.src.States;

public class GameManager
{
    // private IState currentState;
    // GameInterface display= new GameInterface();
    // List<Teams> teams=new List<Teams>; // adding team after creating them

    public GameData gameData = new GameData();
    public GameInterface gameInterface = new GameInterface(); // някъде трябва да подавам данни, ще видим кое къде и на кой етап ще се подава ;()

    public GameManager()
    {
        Transition(States.PrepareForBattleState);
    }
    public void Transition(States newState)
    {
        gameData.currentState?.Destroy();

        switch (newState)
        {
            case States.GameStartState:
                gameData.currentState = new GameStartState(this);
                break;

            case States.PrepareForBattleState:
                gameData.currentState = new PrepareForBattleState(this);
                break;

            case States.BattleState:
                gameData.currentState = new BattleState(this);
                break;

            case States.EndBattleState:
                gameData.currentState = new EndBattleState(this);
                break;

            default:
                throw new System.Exception($"Unknown State: {newState}");
        }

        gameData.currentState.Start();
    }
}
