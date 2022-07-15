using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
        public static int CastSpell(this FantasyWeapon weapon)
        {
            Random random = new Random();
            int damage = random.Next(20) + weapon.DoDamage();
            return damage;
        }
    }
}
