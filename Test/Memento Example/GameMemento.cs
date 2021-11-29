using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Example
{
    public class GameMemento
    {
        private Level level;
        private string username;
        private int gold;

        public GameMemento(Level Level, string Username, int Gold)
        {
            this.level = Level;
            this.username = Username;
            this.gold = Gold;
        }

        public static implicit operator Game(GameMemento gm)
        {
            if (gm != null)
            {
                return new Game(gm.level, gm.username, gm.gold);
            }

            return null;
        }
    }
}