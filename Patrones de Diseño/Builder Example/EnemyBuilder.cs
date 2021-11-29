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
        public class EnemyBuilder : INPCBuilder
        {
            private NPC enemy;

            public EnemyBuilder()
            {
                this.enemy = new NPC();
            }

            public string Name
            {
                set
                {
                    this.enemy.name = value;
                }
            }

            public EnemyType Type
            {
                set
                {
                    this.enemy.type = value;
                }
            }

            public Color Color
            {
                set
                {
                    this.enemy.color = value;
                }
            }

            public int Attack
            {
                set
                {
                    this.enemy.attack = value;
                }
            }

            public int Status
            {
                set
                {
                    this.enemy.status = 2;
                }
            }

            public NPC GetNPC
            {
                get
                {
                    return this.enemy;
                }
            }
        }
    }
}