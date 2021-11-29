using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Example
{
    class HardEnemy : Enemy
    {
        protected override int Attack
        {
            get
            {
                return Convert.ToInt32(Math.Floor(base.Attack * 1.25));
            }
        }

        public HardEnemy(int Attack) : base(Attack) { }
    }
}
