using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalkanGame
{
    public class Grandma : Hero
    {
        public Grandma(int HP, int damage) : base(HP, damage)
        {
        }

        public override void TakeDmg(float dmg)
        {
            throw new NotImplementedException();
        }

        public void HealTeamMate()
        {

        }
    }
}