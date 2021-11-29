using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Example
{
    class DatabaseAccess : IAccessDB
    {
        //true = connected, false = disconnected
        private bool dbState;

        private List<String> information;

        public bool DbState
        {
            get
            {
                return this.dbState;
            }
        }

        public DatabaseAccess()
        {
            this.information = new List<string>();
            this.dbState = false;
        }

        public void ConnectToDB()
        {
            Console.WriteLine("Se connectó a la base de datos correctamente.");
            this.dbState = true;
        }

        public void DisconnectDB()
        {
            Console.WriteLine("Se desconectó de la base de datos correctamente.");
            this.dbState = false;
        }

        public List<String> getInformation()
        {
            if(this.dbState)
            {
                return this.information;
            }
            return null;
        }

        public void SaveInfo(string info)
        {
            this.information.Add(info);
        }
    }
}
