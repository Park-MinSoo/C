using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 어셈블리
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string odir = @"D:\EData\Origin";

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Directory.Exists(@"D:\EData")==false)    // @는 
            {
                Directory.CreateDirectory(@"D:\EData");
            }
            if (Directory.Exists(odir) == false)
            {
                Directory.CreateDirectory(odir);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string fname = string.Format(@"{0}\{1}.txt", odir, tbox_title.Text);
            FileStream fs = File.Create(fname);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(tbox_content.Text);
            sw.Close();
            fs.Close();
            tbox_title.Text = tbox_content.Text = "";
        }
    }
}
