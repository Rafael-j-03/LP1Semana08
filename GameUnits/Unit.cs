using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }
        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine("Unit moved " + movement + " spaces");
        }

        public override string ToString()
        {
            // return type of unit, Health and Cost with 2 decimal places
            return GetType().Name + ":" + 
            " HP=" + Health + 
            " COST=" + Math.Round(Cost, 2);
        }
    }
}