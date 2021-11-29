using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Example
{
    class HardTrap : Trap
    {
        protected override int Damage
        {
            get
            {
                return Convert.ToInt32(Math.Floor(base.Damage * 2.0));
            }
        }
        public HardTrap(int Damage) : base(Damage) { }
    }
}
