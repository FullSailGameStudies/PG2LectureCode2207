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
        private List<string> _items = new List<string>();
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

        public List<string> Items
        {
            get { return _items; }
            private set { _items = value; }
        }
        #endregion
    }
}
