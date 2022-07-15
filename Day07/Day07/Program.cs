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
            playa = Factory.MakePlayer(5, 10, 50, "Bruce Wayne");
            playa.Move(MoveDirection.Right, 5);

            Player player2 = new Player(20, 5, 75, "Arthur");
            player2.Move(MoveDirection.Left, 2);

            Console.WriteLine(Player.NumberOfPlayers);

            Console.WriteLine(playa.Name);//call the get on the property
            playa.Name = "Barry";//call the set on the property

            Inventory backpack = new Inventory(3, new List<FantasyWeapon>());
            //try
            //{
            //    backpack.AddItem("map map");
            //    backpack.AddItem("emergency flask");
            //    backpack.AddItem("sword");
            //    backpack.AddItem("first aid kit");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("oops!");
            //}


            FantasyWeapon sting = Factory.CreateWeapon(WeaponRarity.Legendary, 100, 1000, 1000000);
            int damage = sting.CastSpell(Spell.Fire);// sting.DoDamage();
            Console.WriteLine($"We swing sting and do {damage} damage to the rat.");
            backpack.AddItem(sting);
            backpack.AddItem(new BowWeapon(10, 15, WeaponRarity.Uncommon, 10, 200, 1000));
            Console.WriteLine();
            backpack.PrintInventory();
            Console.WriteLine("\n");

            List<BowWeapon> bows = backpack.Bows();

            Person alfred = new Person("Alfred Pennyworth", 85);
            Superhero batman = new Superhero("Batman", Superpower.Money, "Bruce Wayne", 35);

            int num = 5;
            double dNum = num;//casting? implicit casting
            num = (int)dNum;//casting? explicit casting

            //UPCASTING:
            //from a derived type (Superhero) to a base type (Person)
            Person bruce = batman;//implicitly doing an UPCAST

            Console.WriteLine("\n");
            bruce.Eat("Lobster Pomodor");//which Eat method gets called??
            alfred.Eat("chicken parm");//which Eat method gets called??
            Console.WriteLine("\n");

            //DOWNCASTING
            //NOT SAFE!!
            //from a base type (Person) to a derived type (Superhero)
            //3 ways...
            //1. explicitly cast. MUST use try-catch
            try
            {
                Superhero hero = (Superhero)alfred;
            }
            catch (Exception)
            {
            }

            //2. use the 'as' keyword. must check for null before using.
            Superhero hero2 = alfred as Superhero;
            if(hero2 != null)
                Console.WriteLine(hero2.Identity);
            //if cannot be casted, will hero2 will be set to null

            //3. use pattern matching. 'is' keyword
            if(alfred is Superhero hero3)
                Console.WriteLine(hero3.Identity);

            List<Person> characters = new();
            characters.Add(alfred);
            characters.Add(batman);
            characters.Add(new Superhero("Catwoman", Superpower.Strength, "Selina Kyle", 25));
            characters.Add(new Person("Jim Gordon", 45));

            string food = "pineapple pizza";
            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine($"Hi. I am {characters[i].Name} and I am {characters[i].Age} years old.");
                if (characters[i] is Superhero super)
                    Console.WriteLine($"\t\tAnd I am {super.Identity}! I can {super.Power}!!");

                Console.WriteLine("\nTime to eat!");
                characters[i].Eat(food);
                Console.WriteLine("\n");
            }

            Console.WriteLine("-------WEAPON RARITY-------");
            foreach (var rarity in Enum.GetValues<WeaponRarity>())
            {
                Console.WriteLine(rarity);
            }
        }
    }
}
