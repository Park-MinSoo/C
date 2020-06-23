using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 파일_수신_서버
{
    public class FileRecvServ
    {
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

        public FileRecvServ(string ipstr, int port)
        {
            IPStr = ipstr;
            Port = port;
        }

        Socket sock;
        public bool Start()
        {
            try
            {
                //소켓 생성
                sock = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp
                    );

                //소켓과 네트워크 인터페이스 결합
                IPAddress ipaddr = IPAddress.Parse(IPStr);
                IPEndPoint iep = new IPEndPoint(ipaddr, Port);
                sock.Bind(iep);

                //백로그 큐 크기 결정
                sock.Listen(5);

                //Accept Loop
                AcceptLoopAsyn();
            }
            catch
            {
                return false;
            }
            return true;
        }
        delegate void AcceptDele();
        private void

         AcceptLoopAsyn()
        {
            AcceptDele dele = AcceptLoop;
            dele.BeginInvoke(null, null);
        }

        void AcceptLoop()
        {
            while(true)
            {
                Socket dosock = sock.Accept();
                DoItAsync(dosock);
            }
        }

        Thread thread;
        private void DoItAsync(Socket dosock)
        {
            ParameterizedThreadStart pts = DoIt;
            thread = new Thread(pts);
            thread.Start();
        }

        void DoIt(object osock)
        {
            Socket dosock = osock as Socket;
            string fname = RecvFileName(dosock);
            int length = RecvFileLength(dosock);
            RecvFile(dosock, fname, length);
            dosock.Close();
        }

        private void RecvFile(Socket dosock, string fname, int length)
        {
            byte[] packet = new byte[1024];
            while(length >= 1024)
            {
                int rlen = dosock.Receive(packet);
                length = rlen;
            }
            dosock.Receive(packet, length, SocketFlags.None);
        }

        private int RecvFileLength(Socket dosock)
        {
            byte[] packet = new byte[4];
            dosock.Receive(packet);
            MemoryStream ms = new MemoryStream(packet);
            BinaryReader br = new BinaryReader(ms);
            return br.ReadInt32();
        }

        private string RecvFileName(Socket dosock)
        {
            byte[] packet = new byte[1024];
            dosock.Receive(packet);
            MemoryStream ms = new MemoryStream(packet);
            BinaryReader br = new BinaryReader(ms);
            return br.ReadString();
        }
    }
}
