using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Warrior : Hero
    {
        private const int ExtraDamageChance = 10;

        public Warrior(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(ExtraDamageChance))
            {
                attack = attack * 150 / 100;
            }
            return attack;
        }
    }
}
