using System.Net.Sockets;
using System.Net.Http;
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
        Hero currentHero; // TODO: GO to game data ;)
        
        public void Start()
        {
            dispay.BattleBegin();
            PlayerAtackTurn();
            //display
            BotAtackTurn();
            //display
        }
        public void Destroy()
        {
            throw new NotImplementedException();
        }

        private void Atack(Hero sender)) {
            Hero receiver=ChooseHeroForReceiver();
            
            //new Atack(sender,receiver); Think about putting atack somewhere? Or if u really need the class atack or if u can make it good with delegate and actions
            receiver.TakeDmg(sender.damage);
            display.AtackReceived();
        }

        public void BotAtackTurn(Team botTeam)){
            foreach(hero in botTeam)
            {
                Atack(new Atack(hero,RandomHeroFromTeam()));
            }
            //TODO: Merge player and bot attacks in one
        }

        public void PlayerAtackTurn(Team playerTeam){
            foreach (var hero in playerTeam)
            { if(!IsGrandma)
            {
                AtackHero(hero, ChooseHeroForReceiver())
               }
                  else
                {
                    hero.HealTeamMate(ChooseHeroForReceiver);
                }
            }
        }
        private Hero RandomHeroFromTeam(team){
            Random random = new Random();
            indexOfRandomHero=random.Next(1,team.Count);

            return team[indexOfRandomHero];
        }

        private void AtackHero(Hero sender)
        {
            Atack(new Atack(sender,ChooseHeroForReceiver()););
        }

        public Hero ChooseHeroForReceiver()
        {
            //Invoke menu selected player :) 
        }



    }
}