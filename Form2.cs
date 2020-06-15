using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 데이터_관리
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataManager dm = DataManager.DM;
            int seqno = dm.SeqNo;
            tbox_no.Text = seqno.ToString();
            tbox_title.Text = "";
            tbox_des.Text = "";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int no = int.Parse(tbox_no.Text);
            string title = tbox_title.Text;
            string des = tbox_des.Text;
            DataManager dm = DataManager.DM;            
            if (dm.Contains(no))
            {
                dm.Modify(no, title, des);
                MessageBox.Show("수정했어요.");
            }
            else
            {
                dm.Add(no, title, des);
                lbox_md.Items.Add(no);
                tbox_title.Text = "";
                tbox_des.Text = "";
            }                        
        }

        private void btn_cc_Click(object sender, EventArgs e)
        {
            int no = int.Parse(tbox_no.Text);
            DataManager dm = DataManager.DM;
            if (dm.Contains(no))
            {
                MyData md = dm[no];
                tbox_title.Text = md.Title;
                tbox_des.Text = md.Des;
            }
            else
            {
                tbox_title.Text = "";
                tbox_des.Text = "";
            }
        }

        private void lbox_md_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbox_md.SelectedIndex == -1)
            {
                return;
            }
            int no = (int)lbox_md.SelectedItem;
            tbox_no.Text = no.ToString();
            DataManager dm = DataManager.DM;
            if (dm.Contains(no))
            {
                MyData md = dm[no];
                tbox_title.Text = md.Title;
                tbox_des.Text = md.Des;
            }
            else
            {
                throw new ApplicationException("이상한 버그가 발생");
            }
        }
    }
}
