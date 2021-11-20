using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Example
{
    abstract class Enemy
    {
        private int attack;

        protected virtual int Attack
        {
            get
            {
                return this.attack;
            }
        }

        public Enemy(int Attack)
        {
            this.attack = Attack;
        }

        public virtual int Fight(int hp)
        {
            Console.WriteLine("Te han atacado por " + this.Attack + " puntos de daño.");
            return hp - this.Attack;
        }
    }
}
