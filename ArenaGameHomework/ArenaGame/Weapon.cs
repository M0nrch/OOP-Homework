using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapon
    {
        public string Name { get; private set; }
        public int DamageBoost { get; private set; }
        public string SpecialAbility { get; private set; }

        public Weapon(string name, int damageBoost, string specialAbility)
        {
            Name = name;
            DamageBoost = damageBoost;
            SpecialAbility = specialAbility;
        }

        public virtual int ApplySpecialAbility(int baseDamage)
        {
            return baseDamage;
        }
    }
}
