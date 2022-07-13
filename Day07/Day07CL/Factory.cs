using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Factory
    {
        //build a player instance
        public static Player MakePlayer(int x, int y, int health, string name)
        {
            Player player = new Player(x,y,health,name);
            return player;
        }

        public static FantasyWeapon CreateWeapon(WeaponRarity rarity, int level, int maxDamage, int cost)
        {
            return new FantasyWeapon(rarity,level,maxDamage,cost);
        }
    }
}
