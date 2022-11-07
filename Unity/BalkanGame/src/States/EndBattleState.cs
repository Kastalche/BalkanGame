using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalkanGame.States;

namespace BalkanGame.src.States
{
    public class EndBattleState : IState
    {
        private readonly GameManager game;

        public EndBattleState(GameManager game)
        {
            this.game = game;
        }

        public void Start()
        {
            game.gameInterface.ShowWinner();
            game.gameInterface.NewGame();
        }
        public void Destroy()
        {
            throw new NotImplementedException();
        }

    }
}