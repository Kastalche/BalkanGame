using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalkanGame.States;

namespace BalkanGame.src.States
{
    public class EndBattleState : IState
    {
        public void Start()
        {
            display.ShowWinner();
            display.NewGame();
        }
        public void Destroy()
        {
            throw new NotImplementedException();
        }

    }
}