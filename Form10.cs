using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 지역_검색
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LocaleSearcher_2 Is = new LocaleSearcher_2();
            List<Locale> locales = Is.Search(tbox_query.Text);
            tbox_query.Text = "";
            lbox_locale.DataSource = locales;
        }

        private void lbox_locale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_locale.SelectedIndex == -1)
            {
                return;
            }
            Locale locale = lbox_locale.SelectedItem as Locale;
            lb_lat.Text = locale.Lat.ToString();
            lb_lng.Text = locale.Lng.ToString();

            HtmlDocument hdoc = webBrowser1.Document;
            object[] par = new object[] { locale.Lat, locale.Lng };
            hdoc.InvokeScript("setCenter", par);

        }

    }
}
