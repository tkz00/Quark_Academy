using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Example
{
    class Program
    {

        static void Main(string[] args)
        {
            IObstacleFactory factory;
            Console.WriteLine("Ingrese su HP");
            int hp = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la dificultad: 1 = normal, 2 = dificil");

            switch(Console.ReadLine())
            {
                case "1":
                    factory = new NormalFactory();
                    break;
                case "2":
                    factory = new HardFactory();
                    break;
                default:
                    throw new Exception("La dificultad ingresada no es valida.");
            }

            Enemy enemy = factory.CreateEnemy(10);

            hp = enemy.Fight(hp);

            Trap trap = factory.CreateTrap(6);

            hp = trap.Traverse(hp);

            if(hp <= 0)
            {
                Console.WriteLine("Has muerto");
            }
            else
            {
                Console.WriteLine("Sobreviviste!");
                Console.WriteLine("Tu vida restante es de " + hp + " puntos de vida.");
            }
        }
    }
}
