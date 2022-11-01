using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalkanGame.States;

namespace BalkanGame.src.States
{
    public class BattleState : IState
    {

         Hero currentHero;
        public void Start()
        {
            throw new NotImplementedException();
        }
        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Atack(Atack atack)
        {
            atack.receiver.hp-currentHero.ammountDamage;
        }

    }
}