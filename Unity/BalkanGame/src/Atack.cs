

using System;
using System.Globalization;
namespace BalkanGame.src
{
    public class Atack
    {
        public int ammountDamage { get; set; }
        public Hero sender { get; set; }
        public Hero receiver { get; set; }


        public Atack(Hero sender, hero receiver)
        {
            this.sender=sender;
            this.receiver=receiver;
            this.ammountDamage=sender.damage;
        }
    }
}