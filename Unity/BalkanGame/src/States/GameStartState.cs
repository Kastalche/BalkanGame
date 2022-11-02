using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
public class BGameStartState : IState
    {
        GameInterface display= new GameInterface();
        public void Start()
        {
            display.WelcomePlayer();
        }
        public void Destroy()
        {
            throw new NotImplementedException();
        }