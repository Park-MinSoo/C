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

namespace App1
{
    public partial class 형태소_분석기Form : Form
    {
        public 형태소_분석기Form()
        {
            InitializeComponent();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            MessageBox.Show("원본 파일이 있는 폴더를 선택하세요.");
            fbd.ShowDialog();
            tbox_org.Text = fbd.SelectedPath;

            MessageBox.Show("분석한 파일을 옮길 폴더를 선택하세요.");
            fbd.ShowDialog();
            tbox_par.Text = fbd.SelectedPath;

            MessageBox.Show("분석 내용의 Base 폴더를 선택하세요.");
            fbd.ShowDialog();
            tbox_dat.Text = fbd.SelectedPath;

            btn_mo_parse.Enabled = true;
        }

        private void btn_mo_parse_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(tbox_org.Text);
            FileInfo[] fis = di.GetFiles();
            foreach(FileInfo fi in fis)
            {
                lbox_org.Items.Add(fi.FullName);
            }
        }
    }
}
