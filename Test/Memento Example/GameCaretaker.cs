using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Example
{
    class GameCaretaker
    {
        private List<Game> savedGames = new List<Game>();

        public void AddGame(Game game)
        {
            this.savedGames.Add(game);
        }

        public Game GetGameMemento()
        {
            return this.savedGames.FirstOrDefault();
        }

        public Game GetGameMemento(int index)
        {
            if (0 <= index && index < this.savedGames.Count)
            {
                return this.savedGames[index];
            }
            return null;
        }
    }
}