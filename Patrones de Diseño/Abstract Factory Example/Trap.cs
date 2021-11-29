using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Example
{
    abstract class Trap
    {
        private int damage;

        protected virtual int Damage
        {
            get
            {
                return this.damage;
            }
        }

        public Trap(int Damage)
        {
            this.damage = Damage;
        }

        public virtual int Traverse(int hp)
        {
            Console.WriteLine("Has cruzado la trampa y has sufrido " + this.Damage + " puntos de daño.");
            return hp - this.Damage;
        }
    }
}