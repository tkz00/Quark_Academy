using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Example
{
    interface IObstacleFactory
    {
        Enemy CreateEnemy(int attack);

        Trap CreateTrap(int damage);
    }
}
