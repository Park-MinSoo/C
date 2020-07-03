using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorSelectorLib;

namespace 데모_프로그램
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            int r = int.Parse(tbox_red.Text);
            int g = int.Parse(tbox_green.Text);
            int b = int.Parse(tbox_blue.Text);

            cs.SetColor(r, g, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cs.ChangeColorEventHandler += Cs_ChangeColorEventHandler;
        }

        private void Cs_ChangeColorEventHandler(object sender, ChangeColorEventArgs e)
        {
            tbox_red.Text = e.Red.ToString();
            tbox_green.Text = e.Green.ToString();
            tbox_blue.Text = e.Blue.ToString();
        }
    }
}
