using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Cerberus : Weapon
    {
        public Cerberus() : base("Cerberus", 15, "Freeze")
        {
        }

        public override int ApplySpecialAbility(int baseDamage)
        {
            if (Random.Shared.Next(100) < 20)
            {
                baseDamage = (int)(baseDamage * 1.2);
            }
            return baseDamage;
        }
    }
}
