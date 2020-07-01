using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 검색_서비스_예광탄
{
    public partial class MWebBrowser : Form
    {
        public MWebBrowser(string url)
        {
            InitializeComponent();
            webBrowser1.Navigate(url);
        }
    }
}
