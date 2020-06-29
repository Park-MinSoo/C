using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 자기_자신의_IP주소_획득하기_콘솔_
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPHostEntry
            string hname = Dns.GetHostName();
            IPHostEntry ihe = Dns.GetHostEntry(hname);
            foreach(IPAddress ipaddr in ihe.AddressList)
            {
                if(ipaddr.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine(ipaddr.ToString());
                }
            }
        }
    }
}
