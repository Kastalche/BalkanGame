public class GameManager{
    // private IState currentState;
    // GameInterface display= new GameInterface();
    // List<Teams> teams=new List<Teams>; // adding team after creating them

    gameData game=new GameData();// някъде трябва да подавам данни, ще видим кое къде и на кой етап ще се подава ;()

    public GameManager(Parameters)
    {
        Transition.PrepareForBattleState();
    }
    public void Transition(State newState) {

            currentState?.Destroy();

            switch (newState) {
                case States.PrepareForBattleState:
                    currentState = new PrepareForBattleState(this);
                    break;

                case States.BattleState:
                    currentState = new BattleState(this);
                    break;

                case States.EndBattleState:
                    currentState = new OrderPreparationState(this);
                    break;

                case State.GameStartState.cs:
                    currentState = new GameStartState(this);
                    break;
                default:
                    throw new System.Exception($"Unknown State: {newState}");
            }

            currentState.Start();
        }
    }
}