using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Example
{
    class NormalEnemy : Enemy
    {
        protected override int Attack
        {
            get
            {
                return Convert.ToInt32(Math.Floor(base.Attack * 0.9));
            }
        }
        public NormalEnemy(int Attack) : base(Attack) { }
    }
}
