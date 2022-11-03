using System.Diagnostics;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
public class BGameStartState : IState
    {
        GameData game= new GameData;
        GameInterface display= new GameInterface();
        public void Start()
        {
            game.playerName=display.EnterName();
            display.WelcomePlayer();
        }
        public void Destroy()
        {
            throw new NotImplementedException();
        }