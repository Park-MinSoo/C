﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 인증_클라이언트
{
    class UserInfoCBServer
    {
        public event UserInfoEventHandler UserInfoEventHandler = null;
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

        public UserInfoCBServer(string ipstr, int port)
        {
            IPStr = ipstr;
            Port = port;
        }

        Socket sock = null;
        
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

                //네트워크 인터페이스와 결합
                IPAddress ipaddr = IPAddress.Parse("192.168.10.69");
                IPEndPoint iep = new IPEndPoint(ipaddr,Port); 
                // 포트번호는 임의로 지정해 주는 것이며, 1000번대 이하는 보통 중요한 프로그램이 돌아가기때문에 10000번대로 임의로 설정하였다.
                
                sock.Bind(iep);

                //백로그 큐 크기 결정
                sock.Listen(5); // 동시에 20개도 연결이 가능하다. 순간 5명까지 크기가 되는것.

                //AcceptLoop - 클라이언트 연결 수락 및 송수신
                AcceptLoopAsync();
                return true;
            }

            catch
            {
                return false;
            }
        }

        delegate void AcceptDele();
        private void AcceptLoopAsync()
        {
            AcceptDele dele = AcceptLoop;
            dele.BeginInvoke(null, null);
        }

        void AcceptLoop()
        {
            Socket dosock;
            while(true)
            {
                dosock = sock.Accept();
                DoItAsync(dosock);
            }
        }

        delegate void DoItDele(Socket dosock);
        private void DoItAsync(Socket dosock)
        {
            DoItDele dele = DoIt;
            dele.BeginInvoke(dosock, null, null);
        }

        private void DoIt(Socket dosock)
        {
            byte[] packet = new byte[1024];
            dosock.Receive(packet);
            MemoryStream ms = new MemoryStream(packet);
            BinaryReader br = new BinaryReader(ms);
            string id = br.ReadString();
            string ip = br.ReadString();
            int sport = br.ReadInt32();
            int fport = br.ReadInt32();
            br.Close();
            ms.Close();
            
            if(UserInfoEventHandler != null)
            {
                UserInfoEventHandler(this, new UserInfoEventArgs(id, ip, sport, fport));
            }
            dosock.Close();
        }
    }
}
