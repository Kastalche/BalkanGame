using System;
using BalkanGame.States;

namespace BalkanGame.src.States
{
    public class PrepareForBattleState : IState
    {
        GameInterface display= new GameInterface();
        Random random = new Random();

        public void Start()
        {
            FillTeam();
            display.DisplayTeams();
        }

        public void FillTeam(Team team){
        var randomNumber = random.Next(1,6);
        for(int i=0;i<randomNumber;i++){
            team.heroes.Add(GenerateRandomHero);
            }
        }

        private Hero GenerateRandomHero(){
            int randomNumber=random.Next(1,5);

            switch (randomNumber){
                case 1:
                return new Grandma(100,5);
                case 2:
                return new Haidutin(200,25);
                case 3:
                return new Samodiva(150,15);
                case 4, default:
                return new ZmeyGorqnin(300,50);
                
            }
        }

        

        public void Destroy()
        {
            
        }
        
    }
}