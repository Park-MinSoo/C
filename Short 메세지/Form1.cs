using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiny_메신저
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        smsgServer ss = null;
        private void btn_my_smset_Click(object sender, EventArgs e)
        {
            ss = new smsgServer(tbox_my_ip.Text, int.Parse(tbox_my_smport.Text));
            if(ss.StartAsync())
            {
                tbox_my_ip.Enabled = tbox_my_smport.Enabled = false;
            }
            else 
            {
                MessageBox.Show("숏 메시지 서버 설정 실패!!!");
            }
        }

        IPEndPoint smsg_ep;
        private void btn_other_smset_Click(object sender, EventArgs e)
        {
            IPAddress ipaddr = IPAddress.Parse(tbox_other_ip.Text);
            int port = int.Parse(tbox_my_smport.Text);
            smsg_ep = new IPEndPoint(ipaddr, port);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork,
                 SocketType.Stream,
                 ProtocolType.Tcp
                  );
        sock.Connect(smsg_ep);
        byte[] packet = new byte[1024];
        MemoryStream ms = new MemoryStream(packet);
        BinaryWriter bw = new BinaryWriter(ms);
        bw.Write(tbox_msg.Text);
        bw.Close();
        ms.Close();
        sock.Send(packet);
        sock.Close();
        }
    }
}
