using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Example
{
    //Singleton applied
    public static class EnemyTypes
    {
        static List<EnemyType> List = new List<EnemyType>();


        static EnemyType IsInList(string Name, int NumberOfLegs)
        {
            return List.FirstOrDefault(x => x.Name == Name && x.NumberOfLegs == NumberOfLegs);
        }

        public static EnemyType GetEnemyType(string Name, int NumberOfLegs)
        {
            EnemyType type = IsInList(Name, NumberOfLegs);

            if (type is null)
            {
                type = new EnemyType(Name, NumberOfLegs);
                List.Add(type);
            }

            return type;
        }

        public class EnemyType
        {
            private string name;
            private int numberOfLegs;

            public string Name
            {
                get
                {
                    return this.name;
                }
            }

            public int NumberOfLegs
            {
                get
                {
                    return this.numberOfLegs;
                }
            }

            internal EnemyType(string Name, int NumberOfLegs)
            {
                this.name = Name;
                this.numberOfLegs = NumberOfLegs;
            }

            public override string ToString()
            {
                return $"{this.name} - Legs: {this.numberOfLegs}";
            }
        }
    }
}
