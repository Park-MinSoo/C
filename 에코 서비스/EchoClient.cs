using System;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;

namespace 에코_클라이언트
{
    class EchoClient
    {
        public string IPstr { get; private set; }

        public int Port { get; private set; }

        public EchoClient(string ipstr, int port)
        {
            IPstr = ipstr;
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
            // 네트워크 인터페이스와 결합은 선택적
            //연결 요청
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IPstr), Port);
            sock.Connect(iep);
            //송수신
            byte[] packet = new byte[1024];
            while(true)
            {
                Console.WriteLine("메세지:");
                string msg = Console.ReadLine();
                MemoryStream ms = new MemoryStream(packet);
                BinaryWriter bw = new BinaryWriter(ms);
                bw.Write(msg);
                bw.Close();
                ms.Close();
                sock.Send(packet);
                if(msg == "Exit")
                { 
                    break;
                }
                sock.Receive(packet);
                ms = new MemoryStream(packet);
                BinaryReader br = new BinaryReader(ms);
                string rstr = br.ReadString();
                Console.WriteLine("메세지 잘 가나 보자:{0}", rstr);
            }
            sock.Close();
            // 소캣닫기
        }


    }
}