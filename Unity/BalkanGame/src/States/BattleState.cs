using System.Net.Mail;
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
    public delegate void ShowDamage();

    public class BattleState : IState
    {

        private readonly GameManager game;

        public event ShowDamage AttackMade;

        public BattleState(GameManager game)
        {
            this.game = game;
        }
        int round = 1;
        ///public Hero currentHero; // TODO: GO to game data ;)

         protected virtual void OnAtackSended() //protected virtual method
            {
                ShowDamage?.Invoke(); 
            }

        public void Start(){
            game.gameInterface.BattleBegin();
            PlayerAtackTurn();
            //display
            BotAtackTurn();
            //display
            ShowDamage+=OnAtackMaden;
        }

        public static void OnAtackMaden()
    {
        Console.WriteLine("Atack Maden");
    } 
    //where to put the atack !? ;(
        public void Destroy(){
            throw new NotImplementedException();
        }

        private void Atack(Hero sender){
            Hero receiver = ChooseHeroForReceiver();
            
            if(sender.IsHealer)
            {
                receiver.HP+sender.damage;
                game.gameInterface.HealtTeamMate();
            }
            else
            //new Atack(sender,receiver); Think about putting atack somewhere? Or if u really need the class atack or if u can make it good with delegate and actions
            receiver.TakeDmg(sender.damage);
            game.gameInterface.AtackReceived();
        }

        private void BotAtackTurn(Team botTeam){
            foreach (var hero in botTeam.heroes)
            {
                if (hero is Grandma)
                {

                }
                else
                {
                    Atack(new Atack(hero, RandomHeroFromTeam(your team)));
                }
            }
            //TODO: Merge player and bot attacks in one
        }

        private void PlayerAtackTurn(Team playerTeam){
            foreach (var hero in playerTeam.heroes)
            {
                if (hero is Grandma)
                {
                    hero.HealTeamMate(ChooseHeroForReceiver);//TODO: implement one method to merge heal and atack depending on hero type ;)
                }
                else
                {
                    AtackHero(hero, ChooseHeroForReceiver());
                }
            }
        }
        private Hero RandomHeroFromTeam(Team team)      {
            Random random = new Random();
            int indexOfRandomHero = random.Next(1, team.heroes.Count);

            return team.heroes[indexOfRandomHero];
        }


        public Hero ChooseHeroForReceiver()     {
            return null;
            //Invoke menu selected player :) 
        }



    }
}