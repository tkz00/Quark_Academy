using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Example
{
    interface IAccessDB
    {
        bool DbState { get; }
        void ConnectToDB();

        void DisconnectDB();

        List<String> getInformation();

        void SaveInfo(string info);
    }
}
