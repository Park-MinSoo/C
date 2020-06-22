using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_메신저
{
   public class smsgServer
    {
        //public event RecvedMsgEventHandler RecvedMsgEventHandler = null;
        //public event AcceptedEventHandler AcceptedEventHandler = null;
        
        public string IPStr
        {
            get;
            set;
        }

        public int Port
        {
            get;
            set;
        }

        public smsgServer(string ipstr, int port)
        {
            IPStr = ipstr;
            Port = port;
        }
        Socket sock;
        public bool StartAsync()
        {
            try { 
            //소켓 생성
                sock = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );

            //네트워크 인터페이스와 결합(소켓과 장치 사이의 매핑)
            IPAddress addr = IPAddress.Parse(IPStr);
            IPEndPoint iep = new IPEndPoint(addr, Port);
            sock.Bind(iep);

            //백 로그 큐 크기 설정
            sock.Listen(5);
            AcceptAsync();
            }
            catch
            {
                return false;
            }
            return true;
        }

        delegate void AcceptDele();
        private void AcceptAsync()
        {
            AcceptDele dele = AcceptLoop;
            dele.BeginInvoke(null, null);
        }

        void AcceptLoop()
        { 
            while(true)
            {
                Socket dosock = sock.Accept();
                if(AcceptedEventHandler !=null)
                {
                IPEndPoint rep = dosock.RemoteEndPoint as IPEndPoint;
                AcceptedEventHandler(this, new AcceptedEventArgs(rep));
                }
                
                byte[] packet = new byte[1024];
                dosock.Receive(packet);
                MemoryStream ms = new MemoryStream(packet);
                BinaryReader br = new BinaryReader(ms);
                string msg = br.ReadString();
                br.Close();
                ms.Close();
                if(RecvedMsgEventHandler != null)
                {
                    IPEndPoint rep = dosock.RemoteEndPoint as IPEndPoint;
                    RecvedMsgEventHandler(this, new RecvedMsgEventArgs(rep, msg));
                }
                dosock.Close();
            }
        }


    }
}
