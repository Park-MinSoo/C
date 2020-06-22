using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 에코_서버
{
    class EchoServer
    {
        public string IPStr
        {
            get;
            private set;
        }

        public int Port
        {
            get;
            private set;
        }
        EchoServer(string ipstr, int port)
        {
            IPStr = ipstr;
            Port = port;
        }
        public void Start()
        {
            //소켓 생성
            Socket sock = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );

            //네트워크 인터페이스와 결합
            IPAddress ipaddr = IPAddress.Parse(IPStr);
            IPEndPoint ipend = new IPEndPoint(ipaddr,Port);
            sock.Bind(ipend);

            //백로그 큐 크기 설정
            sock.Listen(5);

            //연결 요처 대기 및 연결 수락...
            while(true)
            {
                Socket dosock = sock.Accept();
                IPEndPoint ripe = dosock.RemoteEndPoint as IPEndPoint;
                Console.WriteLine("{0}:{1}와 연결...", ripe.Address, ripe.Port);
                sock.Close();
            }

        }
    }
}
