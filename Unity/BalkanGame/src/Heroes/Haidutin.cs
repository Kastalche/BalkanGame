using System;

namespace BalkanGame
{
    public class Haidutin : Hero
    {

        public Haidutin(int HP, int damage) : base(HP, damage)
        {
        }

        public override void TakeDmg(float dmg)
        {
            throw new NotImplementedException();
        }

    }
}