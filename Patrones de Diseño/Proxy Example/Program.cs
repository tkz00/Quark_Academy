using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccessDB accessDB = new DBProxy();

            accessDB.ConnectToDB();
            accessDB.SaveInfo("Hola");
            accessDB.SaveInfo("chau");

            foreach (var info in accessDB.getInformation())
            {
                Console.WriteLine(info);
            }

            accessDB.DisconnectDB();

        }
    }
}
