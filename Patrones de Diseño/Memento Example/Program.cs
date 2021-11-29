using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Level level1 = new Level(1, "Prison");
            Level level2 = new Level(2, "Volcano");
            Level level3 = new Level(3, "Mountain");

            GameCaretaker gameCaretaker = new GameCaretaker();

            /////////////////////
            //Without GameMemento
            //¿why does this work?
            /////////////////////
            
            Game game = new Game(level1, "player1", 3);

            Console.WriteLine(game.ToString());

            gameCaretaker.AddGame(game);

            game = new Game(level2, "player1", 5);

            Console.WriteLine(game.ToString());

            gameCaretaker.AddGame(game);

            game = new Game(level3, "player3", 11);

            gameCaretaker.AddGame(game);

            int index = 0;
            Game auxGame = gameCaretaker.GetGameMemento(index);
            while(auxGame != null)
            {
                Console.WriteLine(auxGame.ToString());
                index++;
                auxGame = gameCaretaker.GetGameMemento(index);
            }

            //////////////////
            //With GameMemento
            //////////////////

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            game = new Game(level1, "player1", 3);

            Console.WriteLine(game.ToString());

            GameCaretaker2 gc2 = new GameCaretaker2();

            gc2.AddGame(game);

            game = new Game(level2, "player1", 5);

            Console.WriteLine(game.ToString());

            gc2.AddGame(game);

            game = new Game(level3, "player3", 11);

            gc2.AddGame(game);

            index = 0;
            auxGame = gc2.GetGameMemento();
            while (auxGame != null)
            {
                Console.WriteLine(auxGame.ToString());
                index++;
                auxGame = gc2.GetGameMemento(index);
            }

        }
    }
}
