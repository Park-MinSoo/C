using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 실습LAB1
{
    public partial class Lab1Form1 : Form
    {
        public Lab1Form1()
        {
            InitializeComponent();
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            string word = tbox_one.Text;
            lbox_show.Items.Add(word);
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            tbox_two.Text = "";
            lbox_show.Items.Remove(lbox_show.SelectedItem);
        }

        private void lbox_show_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_show.SelectedItem != null)
            {
                string word2 = lbox_show.SelectedItem.ToString();
                tbox_two.Text = word2;
                tbox_one.Text = "";
                btn_two.Enabled = true;
            }
        }
    }
}
