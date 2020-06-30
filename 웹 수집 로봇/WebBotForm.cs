using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 웹_수집_로봇
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Candidate candi = new Candidate(tbox_url.Text, 0);
            AddCandidate(candi);
        }

        private void AddCandidate(Candidate candi)
        {
            string[] sitems = new string[] { candi.Url, candi.Depth.ToString() };
            ListViewItem lvi = new ListViewItem(sitems);
            lview_candi.Items.Add(lvi);
            lvi.Tag = candi;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lview_candi.Items.Count==0)
            {
                return;
            }
            Candidate candi = lview_candi.Items[0].Tag as Candidate;
            lview_candi.Items.RemoveAt(0);
            WebBrowser wb = new WebBrowser();
            wb.Tag = candi;
            wb.DocumentCompleted += Wb_DocumentCompleted;
            wb.Navigate(candi.Url);
        }

        private void Wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
