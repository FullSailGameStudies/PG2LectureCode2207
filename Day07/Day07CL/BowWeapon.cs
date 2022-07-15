using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class BowWeapon : FantasyWeapon
    {

        public int ArrowCount { get; set; }
        public int ArrowCapacity { get; set; }

        public BowWeapon(int arrowCount, int arrowCapacity, WeaponRarity rarity, int level, int maxDamage, int cost) 
            : base(rarity, level, maxDamage, cost)
        {
            ArrowCount = arrowCount;
            ArrowCapacity = arrowCapacity;
        }

        public override int DoDamage()
        {
            if (ArrowCount > 0)
            {
                ArrowCount--;
                return base.DoDamage();
            }

            return 0;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"\tIt's also a bow with {ArrowCount} arrows and can hold {ArrowCapacity} arrows.");

        }
    }
}
