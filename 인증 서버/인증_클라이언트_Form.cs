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
            EHAAA eaaa = Eaaa;
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
            EHAAA eaaa = Eaaa;
            int re = eaaa.Login(id, pw);
              MessageBox.Show(string.Format("결과 : {0}",re));
            if(re ==0)  // 만약 로그인에 문제가 없다면~
            {
                timer1.Enabled = true;
                int bport = int.Parse(tbox_bport.Text);
                eaaa.KeepAlive(id, "192.168.10.69", 10200, 10989, bport);
                UserInfoCBServer ucbs = new UserInfoCBServer("192.168.10.69",bport);
                ucbs.UserInfoEventHandler += Ucbs_UserInfoEventHandler;
                if(ucbs.Start()==false)
                {
                    MessageBox.Show("허걱.. 예외 발생");
                }

            }
            
        }

        private void Ucbs_UserInfoEventHandler(object sender, UserInfoEventArgs e)
        {
            if (e.FPort == 0)
            { 
                lbox_frd.Items.Remove(e.ID);
            }
            else
            { 
                lbox_frd.Items.Add(e.ID);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string id = tbox_id.Text;
            EHAAA eaaa = Eaaa;
            eaaa.KeepAlive(id);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            string id = tbox_id.Text;
            EHAAA eaaa = Eaaa;
            eaaa.Logout(id);
        }
        EHAAA Eaaa
        {
            get
            {
                return Activator.GetObject(
                typeof(EHAAA),
                "http://192.168.10.69:10800/AAASVC"
                ) as EHAAA;
            }
        }
    }
}
