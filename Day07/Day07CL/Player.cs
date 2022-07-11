using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    //Naming convention: PascalNamingConvention
    public class Player
    {
        //public: everyone can see it
        //private: ONLY my class can see it
        //protected: my class and my descendent classes (children, grandchildren, etc)

        #region Fields
        //FIELDS:
        // data of our class
        // Naming convention: _camelCasingNamingConvention
        private int _x, _y;
        private int _health; 
        #endregion


        #region Properties
        //gatekeepers of the fields (data)
        //Naming convention: PascalNamingConvention

        //just getter/setter methods that look like variables when they are used
        //FULL PROPERTY: you provide the backing field (_health)
        public int Health
        {
            //getter (accessor) method
            //same as public int GetHealth() {return _health;}
            get { return _health; }

            //setter (mutator) method
            //same as public void SetHealth(int value) {_health = value;}
            set //(int value)
            {
                if(value >= 0 && value <= 120)
                    _health = value;
            }

        }

        //auto-property: compiler provides the backing field
        public string Name { get; set; } = "Bruce";
        #endregion

        #region Methods
        //Naming convention: PascalNamingConvention
        #endregion

        #region Constructor (c'tor or ctor)
        //default constructor. no parameters
        //public Player()
        //{
        //    _x = _y = 0;
        //    _health = 120;
        //}
        public Player(int x, int y, int health, string name)
        {
            //x = _x;//BACKWARDS! WRONG!!

            _x = x;
            _y = y;
            Health = health;
            Name = name;// ?? throw new ArgumentNullException(nameof(name));
        }

        #endregion

    }
}
