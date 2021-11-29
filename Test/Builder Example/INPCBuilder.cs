using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder_Example.EnemyTypes;

namespace Builder_Example
{
    public interface INPCBuilder
    {
        string Name { set; }
        EnemyType Type { set; }
        Color Color { set; }
        int Attack { set; }
        int Status { set; }
        NPC GetNPC { get; }
    }
}
