using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player playa;
            //playa = new Player();//create an instance
            playa = new Player(5, 10, 50, "Bruce Wayne");
            playa.Move(MoveDirection.Right, 5);

            Player player2 = new Player(20, 5, 75, "Arthur");
            player2.Move(MoveDirection.Left, 2);

            Console.WriteLine(Player.NumberOfPlayers);

            Console.WriteLine(playa.Name);//call the get on the property
            playa.Name = "Barry";//call the set on the property

            Inventory backpack = new Inventory(3, new List<string>());
            try
            {
                backpack.AddItem("map map");
                backpack.AddItem("emergency flask");
                backpack.AddItem("sword");
                backpack.AddItem("first aid kit");
            }
            catch (Exception)
            {
                Console.WriteLine("oops!");
            }


            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 1000, 1000000);
            int damage = sting.DoDamage();
            Console.WriteLine($"We swing sting and do {damage} damage to the rat.");
        }
    }
}
