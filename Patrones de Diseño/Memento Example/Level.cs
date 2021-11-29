using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Example
{
    public class Level
    {
        private int number;
        private string name;

        public Level(int Number, string Name)
        {
            this.number = Number;
            this.name = Name;
        }

        public override string ToString()
        {
            return this.number.ToString() + " - " + this.name.ToString();
        }
    }
}
