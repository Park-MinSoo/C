using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 검색_서비스_예광탄
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string query = tbox_query.Text;
            List<RankedUrl> rurls = SearchEngine.Search(query);
            foreach (RankedUrl rurl in rurls)
            {
                string[] sitems = new string[] { rurl.Title, rurl.Url, rurl.Score.ToString() };
                ListViewItem lvi = new ListViewItem(sitems);
                lv_result.Items.Add(lvi);
            }
            Text = tbox_query.Text;
            tbox_query.Text = "";
        }

        private void lv_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_result.SelectedItems.Count <=0)
            {
                return;
            }
            ListViewItem lvi = lv_result.SelectedItems[0];
            string url = lvi.SubItems[1].Text;
            MWebBrowser mwb = new MWebBrowser(url);
            mwb.Show();
        }
    }

}
