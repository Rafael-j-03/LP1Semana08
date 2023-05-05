using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class DiplomatUnit : XPUnit
    {
        public override float Cost => 7.1f;
        public DiplomatUnit() : base(6, 1)
        {
        }

        public void MakeAgreement(Unit unit)
        {
            if (unit is DiplomatUnit)
            {
                XP += 3;
            }
            else if (unit is SettlerUnit)
            {
                XP += 2;
            }
            else
            {
                XP++;
            }
        }
    }
}