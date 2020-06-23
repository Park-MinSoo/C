using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 파일_수신_서버
{
    class RecvFileNameEventArgs : EventArgs
    {
        public delegate void RecvFileNameEventHandler(object sender, RecvFileNameEventArgs e);
        public string FileName { get; private set; }
        public IPEndPoint RemoteEP { get; private set; }

        public RecvFileNameEventArgs(string fname, IPEndPoint rep)
        {
            FileName = fname;
            RemoteEP = rep;
        }
    }
}