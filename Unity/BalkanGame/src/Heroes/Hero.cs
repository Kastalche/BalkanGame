namespace BalkanGame
{
    public abstract class Hero
    {
        public int HP { get; set; }
        public int damage { get; set; }

        private int XP { get; set; }
        private int level { get; set; }
        private bool IsHealer{ get; set; }

        public Hero(int HP, int damage)
        {
            this.HP = HP;
            this.damage = damage;

            level = 1;
            XP = 0;
        }

        // public abstract void Atack(List<Actor> team, Actor atackedActor);
        public bool IsAlive()
        {
            return HP > 0;
        }
        public void TakeDmg(int dmg)
        {
            HP = HP - dmg;
        }

    }
}