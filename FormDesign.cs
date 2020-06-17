using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 리스트_뷰어
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string[] its = new string[4];
            its[0] = tbox_title.Text;
            its[1] = tbox_author.Text;
            its[2] = tbox_publisher.Text;
            its[3] = tbox_price.Text;
            ListViewItem lvi = new ListViewItem(its);
            lv_book.Items.Add(lvi);
            tbox_price.Text = "";
            tbox_author.Text = "";
            tbox_publisher.Text = "";
            tbox_title.Text = "";
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lv_book.SelectedItems[0];
            lv_book.Items.Remove(lvi);
        }

        private void lv_book_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_book.SelectedItems.Count<=0)  // 선택 항목이 0보다 작다 -> 즉, 선택 항목이 없다.
            {
                btn_remove.Enabled = false;
                this.Text = "Form1";
                return;
            }
            btn_remove.Enabled = true;
            ListViewItem lvi = lv_book.SelectedItems[0];
            string str = "";
            foreach(ListViewItem.ListViewSubItem lvs in lvi.SubItems)   // 선택 항목의 각 컬럼들의 값을 하나의 문자로 합성한 것이다.
            {
                str = str + lvs.Text + "";
            }
            this.Text = str;
        }
    }
}
