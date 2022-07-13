using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Person
    {
        private string _socialSecurity = "123-45-6789";
        protected double _money = double.MaxValue;
        public string Name { get; set; }
        public int Age { get; set; }

       
        public Person(string name, int age)
{
            Console.WriteLine($"Person: {name}, {age}");
            //?? - null coallescing operator
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"I am eating {food}. nom nom.");
        }
    }
}
