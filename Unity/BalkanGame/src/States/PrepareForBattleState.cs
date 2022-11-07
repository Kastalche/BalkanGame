using System;
using BalkanGame.States;

namespace BalkanGame.src.States
{
    public class PrepareForBattleState : IState
    {
        Random random = new Random();
        private readonly GameManager game;

        public PrepareForBattleState(GameManager game)
        {
            this.game = game;
        }


        public void Start()
        {
            FillTeams();
            game.gameInterface.DisplayTeams();
        }

        public void CreateTeams(int numberOfTeams)
        {
            for (int i = 0; i < numberOfTeams; i++)
            {
                Team newTeam = new Team();
                game.gameData.teams.Add(newTeam);
            }
        }

        public void FillTeams()

        {
            foreach (var team in game.gameData.teams)
            {
                FillTeam(team);
            }
        }

        private void FillTeam(Team team)
        {
            var randomNumber = random.Next(1, 6);
            for (int i = 0; i < randomNumber; i++)
            {
                team.heroes.Add(GenerateRandomHero());
            }
        }

        private Hero GenerateRandomHero()
        {
            int randomNumber = random.Next(1, 5);

            switch (randomNumber)
            {
                case 1:
                    return new Grandma(100, 5);
                case 2:
                    return new Haidutin(200, 25);
                case 3:
                    return new Samodiva(150, 15);
                case 4:
                default:
                    return new ZmeyGorqnin(300, 50);

            }
        }



        public void Destroy()
        {

        }

    }
}