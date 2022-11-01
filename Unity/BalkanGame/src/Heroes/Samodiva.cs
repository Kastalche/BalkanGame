using System;

namespace BalkanGame
{
    public class Samodiva : Hero
    {
        public Samodiva(int HP, int damage) : base(HP, damage)
        {
        }

        public override void TakeDmg(float dmg)
        {
            throw new NotImplementedException();
        }
    }
}