public class GameManager{
    private IState currentState;

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
                    currentState = new BattleStatethis);
                    break;

                case States.EndBattleState:
                    currentState = new OrderPreparationState(this);
                    break;

                case State.sGameStartState.cs:
                    currentState = new GameStartState(this);
                    break;
                default:
                    throw new System.Exception($"Unknown State: {newState}");
            }

            currentState.Start();
        }
    }
}