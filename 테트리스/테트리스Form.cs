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
                case Keys.Up: Turn(); break;
                case Keys.Down: NextBlock(); break;
            }
        }

        private void NextBlock()
        {
            diagram.SetXY(5, 0);
            Invalidate();
        }

        private void Turn()
        {
            diagram.Turn();
            Invalidate();
        }

        private void Move(int cx, int cy)
        {
            if (board.CheckMoveEnable(diagram, cx, cy))
            { 
            diagram.Move(cx, cy);
            Invalidate();   // 다시그려주세요
            }
        }

        const int step = 30;
        Diagram diagram = new Diagram(5, 0);
        Board board = new Board();


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            DrawDiagram(graphics);
            DrawBoard(graphics);
        }

        private void DrawBoard(Graphics graphics)
        {
            board.bdvals[9, 9] = 1;
            for (int cy = 0; board.MAX_Y < 4; cy++)
            {
                for (int cx = 0; board.MAX_X < 4; cx++)
                {
                    if (board.bdvals[cy, cx] == 1)
                    {
                        Rectangle rect = new Rectangle(cx* step, cy * step, step, step);
                        graphics.DrawRectangle(Pens.Red, rect);
                        rect.X += 2;
                        rect.Y += 2;
                        rect.Width -= 4;
                        rect.Height -= 4;
                        graphics.FillRectangle(Brushes.BlanchedAlmond, rect);

                    }
                }
            }
        }

        private void DrawDiagram(Graphics graphics)
        {
            int tn = diagram.TN;
            int x = diagram.X;
            int y = diagram.Y;
            int bn = diagram.BN;
            for (int cy=0;cy<4;cy++)
            {
                for(int cx=0;cx<4;cx++)
                {
                    if(Diagram.bvalue[bn,tn,cy,cx]==1)
                    {
                        Rectangle rect = new Rectangle((x + cx)* step, (y + cy)* step, step, step);
                        graphics.DrawRectangle(Pens.Red, rect);
                        rect.X += 2;
                        rect.Y += 2;
                        rect.Width -= 4;
                        rect.Height -= 4;
                        graphics.FillRectangle(Brushes.BlanchedAlmond, rect);

                    }
                }
            }
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

            int width = step * board.MAX_X + 18;
            int height = step + board.MAX_Y + 32;
            this.Size = new Size(Width, height);
        }
    }
}
