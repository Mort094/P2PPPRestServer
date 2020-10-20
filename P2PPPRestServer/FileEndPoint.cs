using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2PPPRestServer
{
    public class FileEndPoint
    {
        private string _ipAddress;
        private string _port;
        

        public string IPAddress
        {
            get { return _ipAddress; }
            set { _ipAddress = value; }
        }

        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public FileEndPoint()
        {

        }

        public FileEndPoint(string ipAdress, string port)
        {
            IPAddress = ipAdress;
            Port = port;
        }

        public override string ToString()
        {
            return $"Ip adress is: {IPAddress}, port is {Port}";
        }
    }
}
