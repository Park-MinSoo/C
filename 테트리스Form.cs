using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 테트리스
{
    public partial class 테트리스Form : Form
    {
        public 테트리스Form()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left: Move(-1,0); break;
                case Keys.Right: Move(1,0); break;
                case Keys.Up: Move(0,-1); break;
                case Keys.Down: Move(0,1); break;
            }
        }

        private void Move(int cx, int cy)
        {
            pt.X += cx;
            pt.Y += cy;
            Invalidate();   // 다시그려주세요
        }

        const int step = 15;
        Point pt = new Point(5, 0);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rect = new Rectangle(pt.X * step, pt.Y * step, step, step);
            graphics.DrawRectangle(Pens.Red, rect);
            rect.X += 2;
            rect.Y += 2;
            rect.Width -= 4;
            rect.Height -= 4;
            graphics.FillRectangle(Brushes.BlanchedAlmond, rect);



        }

        private void tm_tm_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToShortTimeString();
        }

        private void tm_down_Tick(object sender, EventArgs e)
        {
            Move(0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
