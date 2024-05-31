using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Paladin : Hero
    {
        private const int HealChance = 20;

        public Paladin(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(HealChance))
            {
                Heal(StartingHealth * 20 / 100);
            }
            return attack;
        }
    }
}
