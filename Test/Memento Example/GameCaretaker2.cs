using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Example
{
    class GameCaretaker2
    {
        private List<GameMemento> savedGames = new List<GameMemento>();

        public void AddGame(GameMemento game)
        {
            this.savedGames.Add(game);
        }

        public GameMemento GetGameMemento()
        {
            return this.savedGames.FirstOrDefault();
        }

        public GameMemento GetGameMemento(int index)
        {
            if (0 <= index && index < this.savedGames.Count)
            {
                return this.savedGames[index];
            }
            return null;
        }
    }
}
