using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder_Example.EnemyTypes;

namespace Builder_Example
{
    public partial class NPC
    {
        private string name;
        private EnemyType type;
        private Color color;
        private int attack;
        //1 = friendly, 2 = aggresive
        private int status;

        public override string ToString()
        {
            return $"{this.name} - {this.type.ToString()} - {this.color} - Attack: {this.attack} - {(this.status == 1 ? "Friendly" : "Aggressive")}";
        }
    }
}
