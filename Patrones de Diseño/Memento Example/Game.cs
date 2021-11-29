using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Example
{
    //Originator Class
    public class Game
    {
        private Level level;
        private string username;
        private int gold;

        public Game(Level Level, string Username, int Gold)
        {
            this.level = Level;
            this.username = Username;
            this.gold = Gold;
        }

        public override string ToString()
        {
            return string.Format("{0} - Username: {1} - Gold: {2}", this.level.ToString(), this.username, this.gold.ToString());
        }

        public static implicit operator GameMemento(Game game)
        {
            if (game != null)
            {
                return new GameMemento(game.level, game.username, game.gold);
            }

            return null;
        }
    }
}
