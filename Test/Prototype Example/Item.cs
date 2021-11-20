using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Example
{
    public class Item
    {
        public IdInfo id;
        public string type;
        public string name;
        public Color color;

        public Item(string Name, Color Color)
        {
            Random rnd = new Random();
            this.type = (rnd.NextDouble() <= 0.33 ? "Arma" : (rnd .NextDouble() <= 0.66 ? "Armadura" : "Escudo"));
            this.name = Name;
            this.color = Color;
            this.id = new IdInfo(rnd.Next(1, 10000));
        }

        public override string ToString()
        {
            return "Id: " + this.id.IdNumber + ", Nombre: " + this.name + ", Tipo: " + this.type + ", Color: " + this.color;
        }

        public Item ShallowCopy()
        {
            return (Item)this.MemberwiseClone();
        }

        public Item DeepCopy()
        {
            Item newItem = (Item)this.MemberwiseClone();
            newItem.id = new IdInfo(id.IdNumber);
            newItem.color = this.color;
            return newItem;
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

}
