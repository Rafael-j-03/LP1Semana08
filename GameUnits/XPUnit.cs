using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class XPUnit : Unit
    {
        public int XP { get; protected set; }

        // Constructor
        public XPUnit(int movement, int health) : base(movement, health)
        {
            XP = 0;
        }
    }
}