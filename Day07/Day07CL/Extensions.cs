using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
        public static int CastSpell(this FantasyWeapon weapon, Spell spell)
        {
            Random random = new Random();
            int damage;
            switch (spell)
            {
                case Spell.Fire:
                    damage = random.Next(20);
                    break;
                case Spell.Lightning:
                    damage = random.Next(10);
                    break;
                case Spell.Freeze:
                    damage = random.Next(5);
                    break;
                default:
                    damage = 0;
                    break;
            }
            damage += weapon.DoDamage();
            return damage;
        }
    }
}
