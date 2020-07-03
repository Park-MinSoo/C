using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSelectorLib
{
    public partial class ColorSelector: UserControl
    {
        public ColorSelector()
        {
            InitializeComponent();
        }

        private void tb_red_Scroll(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void ChangeColor()
        {
            int r = tb_red.Value;
            int g = tb_green.Value;
            int b = tb_blue.Value;
            splitContainer1.Panel1.BackColor = Color.FromArgb(r, g, b);
            tbox_red.Text = r.ToString();
            tbox_green.Text = g.ToString();
            tbox_blue.Text = b.ToString();
        }

        private void tb_green_Scroll(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void tb_blue_Scroll(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void ColorSelector_Load(object sender, EventArgs e)
        {
            ChangeColor();
        }
        public void SetColor(int r, int g, int b)
        {
            tb_red.Value = r;
            tb_green.Value = g;
            tb_blue.Value = b;
            ChangeColor();
        }
    }
}
