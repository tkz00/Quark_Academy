using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Example
{
    class NormalFactory : IObstacleFactory
    {
        public Enemy CreateEnemy(int attack)
        {
            return new NormalEnemy(attack);
        }

        public Trap CreateTrap(int damage)
        {
            return new NormalTrap(damage);
        }
    }
}
