using System.Security.Cryptography;
using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalkanGame.States;

namespace BalkanGame.src.States
{
    public class BattleState : IState
    {
        int round=1;
        Hero currentHero;
        
        public void Start()
        {
            dispay.BattleBegin();
        }
        public void Destroy()
        {
            throw new NotImplementedException();
        }

        private void Atack(Atack atack)
        {
            atack.receiver.hp-currentHero.ammountDamage;
            display.AtackReceived();
        }

        public void BotAtackTurn(Team botTeam)){
            foreach(hero in botTeam)
            {
                Atack(new Atack(hero,RandomHeroFromTeam()));
            }
            //TODO: Merge player and bot attacks in one
        }

        public void PlayerAtackTurn(Team playerTeam)
        {
            foreach (var hero in playerTeam)
            {
                //TODO: Choose receiver for the attack; 
            }
        }
        private Hero RandomHeroFromTeam(team){
            Random random = new Random();
            indexOfRandomHero=random.Next(1,team.Count);

            return team[indexOfRandomHero];
        }



    }
}