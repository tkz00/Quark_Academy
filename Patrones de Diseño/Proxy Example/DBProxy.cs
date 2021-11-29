using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Example
{
    class DBProxy : IAccessDB
    {
        private IAccessDB real;

        public bool DbState => real.DbState;

        public void ConnectToDB()
        {
            //Virtual Proxy
            if(this.real == null)
            {
                this.real = new DatabaseAccess();
            }

            try
            {
                this.real.ConnectToDB();

                //Record-Keeping Proxy
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DBAccessRecord.txt");

                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                using(var stream = File.Open(path, FileMode.Append))
                {
                    string dataasstring = "Connection " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + Environment.NewLine;
                    byte[] info = new UTF8Encoding(true).GetBytes(dataasstring);
                    stream.Write(info, 0, info.Length);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DisconnectDB()
        {
            //Virtual Proxy
            if (this.real == null)
            {
                this.real = new DatabaseAccess();
            }

            try
            {
                this.real.DisconnectDB();

                //Record-Keeping Proxy
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DBAccessRecord.txt");

                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                using (var stream = File.Open(path, FileMode.Append))
                {
                    string dataasstring = "Disconnection " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + Environment.NewLine;
                    byte[] info = new UTF8Encoding(true).GetBytes(dataasstring);
                    stream.Write(info, 0, info.Length);
                    stream.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<string> getInformation()
        {
            return this.real.getInformation();
        }

        public void SaveInfo(string data)
        {
            if (this.real == null)
            {
                this.real = new DatabaseAccess();
            }

            if(!this.real.DbState)
            {
                throw new Exception("¨The DataBase exists but it's not accessible.");
            }

            try
            {
                this.real.SaveInfo(data);

                //Record-Keeping Proxy
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DBAccessRecord.txt");
                string message = "Saved info " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + Environment.NewLine;

                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                using (var stream = File.Open(path, FileMode.Append))
                {
                    string dataasstring = message;
                    byte[] info = new UTF8Encoding(true).GetBytes(dataasstring);
                    stream.Write(info, 0, info.Length);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
