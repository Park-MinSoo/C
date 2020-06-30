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
    public partial class WebBotForm : Form
    {
        public WebBotForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Candidate candi = new Candidate(tbox_url.Text, 0);
            AddCandidate(candi);
        }

        Dictionary<string, PostedUrl> pdic = new Dictionary<string, PostedUrl>();
        private void AddCandidate(Candidate candi)
        {
            if(Filter(candi.Url))
            {
                return;
            }
            string url = candi.Url;
            int index = url.IndexOf("#");
            if(index != -1)
            {
                url = url.Substring(0, index);
                candi = new Candidate(url, candi.Depth);
            }
            if(pdic.ContainsKey(candi.Url))
            {
                return;
            }
            string[] sitems = new string[] { candi.Url, candi.Depth.ToString() };
            ListViewItem lvi = new ListViewItem(sitems);
            lview_candi.Items.Add(lvi);
            lvi.Tag = candi;
        }

        private bool Filter(string url)
        {
            return url.EndsWith(".zip") || url.EndsWith(".hwp");
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
            wb.ScriptErrorsSuppressed = true;
            wb.Tag = candi;
            wb.DocumentCompleted += Wb_DocumentCompleted;
            wb.Navigate(candi.Url);
        }

        private void Wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb = sender as WebBrowser;
            Candidate candi = wb.Tag as Candidate;
            HtmlDocument hdoc = wb.Document;
            //수집한 내용을 저장하는 부분은 to be defined
            if(candi.Depth>=5)
            {
                return;
            }
            string url;
            foreach(HtmlElement he in hdoc.Links)
            {
                url = he.GetAttribute("href");
                AddCandidate(new Candidate(url, candi.Depth + 1));
            }
            string aurl = e.Url.AbsoluteUri;
            if(pdic.ContainsKey(aurl))
            {
                return;
            }
            PostedUrl purl = new PostedUrl(aurl, candi.Depth, hdoc.Title, hdoc.Body.InnerText);
            pdic[aurl] = purl;
            purl.Save();
        }
            
        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
