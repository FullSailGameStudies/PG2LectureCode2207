using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public enum Superpower
    {
        Money, Strength, Flight, Teleportation, Speed, Swimming
    }
    //Derived class OR Specialization
    //inheriting EVERYTHING from Person
    public class Superhero : Person
    {
        public Superpower Power { get; set; }
        public string Identity { get; set; }

        public Superhero() : base("Bruce Wayne", 35)
        {
            Power = Superpower.Money;
            Identity = "Batman";
        }

        //my derived constructor needs to call the base constructor
        //base("Bruce",35) same as = new Person("Bruce", 35)
        public Superhero(string identity, Superpower power, string name, int age)
            : base(name, age)
        {
            Console.WriteLine($"Superhero: {identity}, {power}");
            Identity = identity;
            Power = power;
        }

        //override Eat
        public override void Eat(string food)
        {
            Console.WriteLine("I stand ready and prepare to eat!");
            base.Eat(food);//EXTEND the base version
            Console.WriteLine("Now I'm ready to defend the planet.");
        }

        public override void DoWork()
        {
            //FULLY override. DON'T call the base version.
            //base.DoWork();
            Console.WriteLine($"I use {Power} to save the planet! You're welcome.");
        }
    }
}
