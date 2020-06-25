using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인증_클라이언트
{
     delegate void UserInfoEventHandler(object sender, UserInfoEventArgs e);
    class UserInfoEventArgs:EventArgs
    {
        public string ID
        {
            get;
            private set;
        }
        public string IPStr
        {
            get;
            private set;
        }

        public int SPort
        {
            get;
            private set;
        }
        public int FPort
        {
            get;
            private set;
        }

        public UserInfoEventArgs(string id, string ipstr, int sport, int fport)
        {
            ID = id;
            IPStr = ipstr;
            SPort = sport;
            FPort = fport;
        }
    }
}
