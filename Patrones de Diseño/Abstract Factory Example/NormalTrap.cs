using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Example
{
    class NormalTrap : Trap
    {
        protected override int Damage
        {
            get
            {
                return Convert.ToInt32(Math.Floor(base.Damage * 0.5));
            }
        }
        public NormalTrap(int Damage) : base(Damage) { }
    }
}
