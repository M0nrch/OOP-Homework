using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Ignis : Weapon
    {
        public Ignis() : base("Flaming Sword", 20, "Burn")
        {
        }

        public override int ApplySpecialAbility(int baseDamage)
        {
            if (Random.Shared.Next(100) < 25)
            {
                baseDamage += 10;
            }
            return baseDamage;
        }
    }
}
