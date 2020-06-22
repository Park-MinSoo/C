using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 에코_클라이언트
{
    class Program
    {
        static void Main(string[] args)
        {
            EchoClient ec = new EchoClient("192,168,10,111", 10340);
            ec.Start();
        }
    }
}
