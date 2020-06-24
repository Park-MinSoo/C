using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EHAAALib;

namespace 인증_클라이언트
{
    public partial class 인증_클라이언트_Form : Form
    {
        public 인증_클라이언트_Form()
        {
            InitializeComponent();
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            string id = tbox_id.Text;
            string pw = tbox_pw.Text;
            EHAAA eaaa = Activator.GetObject(
                typeof(EHAAA),
                "http://192.168.10.69:10800/AAASVC"
                ) as EHAAA;
            if(eaaa.join(id,pw))
            {
                MessageBox.Show("가입 성공");
            }
            else
            {
                MessageBox.Show("가입 실패");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpChannel hc = new HttpChannel();
            ChannelServices.RegisterChannel(hc, false);

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string id = tbox_id.Text;
            string pw = tbox_pw.Text;
            EHAAA eaaa = Activator.GetObject(
                typeof(EHAAA),
                "http://192.168.10.69:10800/AAASVC"
                ) as EHAAA;
            int re = eaaa.Login(id, pw);
              MessageBox.Show(string.Format("결과 : {0}",re));
            
        }
    }
}
