using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 파일_수신_서버
{
    public delegate void FileLengthRecvEventHandler(object sender, FileLengthRecvEventArgs e);
    public class FileLengthRecvEventArgs : EventArgs
    {
        public string FileName { get; private set; }
        public IPEndPoint RemoteEP { get; private set; }

        public int Length { get; private set; }

        public FileLengthRecvEventArgs(string fname, IPEndPoint rep, int length)
        {
            FileName = fname;
            RemoteEP = rep;
            Length = length;
        }
    }
}