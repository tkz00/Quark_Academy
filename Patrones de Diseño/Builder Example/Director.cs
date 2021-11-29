using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Example
{
    public class Director
    {
        private INPCBuilder builder;

        public INPCBuilder Builder
        {
            set
            {
                this.builder = value;
            }
        }

        public NPC BuildOrc()
        {
            if(this.builder != null)
            {
                this.builder.Name = "Orc";
                this.builder.Type = EnemyTypes.GetEnemyType("Humanoid", 2);
                this.builder.Color = Color.Green;
                this.builder.Attack = 12;
                return this.builder.GetNPC;
            }

            throw new NullReferenceException();
        }

        public NPC BuildFireElemental()
        {
            if (this.builder != null)
            {
                this.builder.Name = "Fire Elemental";
                this.builder.Type = EnemyTypes.GetEnemyType("Elemental", 0);
                this.builder.Color = Color.OrangeRed;
                this.builder.Attack = 19;
                return this.builder.GetNPC;
            }

            throw new NullReferenceException();
        }
    }
}
