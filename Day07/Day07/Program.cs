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

            Console.WriteLine(playa.Name);//call the get on the property
            playa.Name = "Barry";//call the set on the property

            int x, y;
        }
    }
}
