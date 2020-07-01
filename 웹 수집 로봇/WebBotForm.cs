using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

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
        List<string> curls = new List<string>();
        private void AddCandidate(Candidate candi)
        {
            if (Filter(candi.Url))
            {
                return;
            }
            ConvertUrl(ref candi);
            if (pdic.ContainsKey(candi.Url) || curls.Contains(candi.Url))
            {
                return;
            }
            string[] sitems = new string[] { candi.Url, candi.Depth.ToString() };
            ListViewItem lvi = new ListViewItem(sitems);
            lview_candi.Items.Add(lvi);
            lvi.Tag = candi;
            curls.Add(candi.Url);
        }

        private void ConvertUrl(ref Candidate candi)
        {
            // # 뒤의 내용들을 제거
            string url = candi.Url;
            int index = url.IndexOf("#");
            if (index != -1)
            {
                url = url.Substring(0, index);
                candi = new Candidate(url, candi.Depth);
            }
            // ? 뒤의 내용들을 제거
            index = url.IndexOf("?");
            if (index != -1)
            {
                url = url.Substring(0, index);
                candi = new Candidate(url, candi.Depth);
            }
        }

        private bool Filter(string url)
        {

            return url.EndsWith(".zip") || url.EndsWith(".hwp") || url.StartsWith("java")||(!(url.StartsWith("http")||url.StartsWith("https")));
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        Candidate sel_candi;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lview_candi.Items.Count == 0)
            {
                return;
            }
            Candidate candi = lview_candi.Items[0].Tag as Candidate;
            lview_candi.Items.RemoveAt(0);

            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;

            /*            string html = wc.DownloadString(candi.Url);
                        HtmlAgilityPack.HtmlDocument hdoc = new HtmlAgilityPack.HtmlDocument();
                        hdoc.LoadHtml(html);
            */
            wc.DownloadStringCompleted += Wc_DownloadStringCompleted;
            wc.DownloadStringAsync(new Uri(sel_candi.Url));
        }

        /*           WebBrowser wb = new WebBrowser();
                   wb.ScriptErrorsSuppressed = true;
                   wb.Tag = candi;
                   wb.DocumentCompleted += Wb_DocumentCompleted;
                   wb.Navigate(candi.Url);
              */

        /*    private void Wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
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
        */
            private void btn_stop_Click(object sender, EventArgs e)
            {
                timer1.Enabled = false;
            }
        


        private void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            HtmlAgilityPack.HtmlDocument hdoc = new HtmlAgilityPack.HtmlDocument();
            hdoc.LoadHtml(e.Result);

            if (sel_candi.Depth >= 5)
            {
                return;
            }
            string url;
            HtmlNodeCollection hnc =  hdoc.DocumentNode.SelectNodes("//a");
            foreach (HtmlNode he in hnc)
            {
                if (he.Attributes["href"] != null)
                {
                    url = he.Attributes["href"].Value;
                    AddCandidate(new Candidate(url, sel_candi.Depth + 1));
                }
            }
            string aurl = sel_candi.Url;
            if (pdic.ContainsKey(aurl))
            {
                return;
            }
            HtmlNode thn = hdoc.DocumentNode.SelectSingleNode("//title");
            string title = thn.InnerText;
            HtmlNode bhn = hdoc.DocumentNode.SelectSingleNode("//body");
            string body = bhn.InnerText;

            PostedUrl purl = new PostedUrl(aurl, sel_candi.Depth, title, body);
            pdic[aurl] = purl;
            purl.Save();
        }
    }
}