using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder_Example.NPC;

namespace Builder_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            INPCBuilder enemyBuilder = new EnemyBuilder();

            director.Builder = enemyBuilder;

            NPC orc = director.BuildOrc();

            Console.WriteLine(orc.ToString());

            NPC elemental = director.BuildFireElemental();

            Console.WriteLine(elemental.ToString());
        }
    }
}
