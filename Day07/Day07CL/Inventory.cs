using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Inventory
    {
        #region Fields
        private int _capacity = 0;
        private List<FantasyWeapon> _items = new List<FantasyWeapon>();
        #endregion

        #region Properties
        //gatekeepers of the fields (data)
        //just getter/setter methods that look like variables when they are used

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value > 0) _capacity = value;
            }
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public List<FantasyWeapon> Items
        {
            get { return _items; }
            private set { _items = value; }
        }
        #endregion

        public Inventory(int capacity, List<FantasyWeapon> items)
        {
            Capacity = capacity;
            Items = new List<FantasyWeapon>(items);//clone
        }

        public void AddItem(FantasyWeapon itemToAdd)
        {
            if (Count == Capacity)
                throw new Exception("our inventory is full, fool!");

            _items.Add(itemToAdd);
        }

        public void PrintInventory()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                FantasyWeapon fw = _items[i];
                fw.Display();
                //Console.WriteLine($"I have a level {fw.Level} {fw.Rarity} weapon that costs {fw.Cost} and can do {fw.MaxDamage} max damage.");
                //if (fw is BowWeapon bow)
                //    Console.WriteLine($"\tIt's also a bow with {bow.ArrowCount} arrows and can hold {bow.ArrowCapacity} arrows.");
            }
        }
    }
}
