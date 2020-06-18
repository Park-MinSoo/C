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
        Pen[] pens = new Pen[7]{Pens.Black,Pens.DarkGray,Pens.Cyan,Pens.AliceBlue,
            Pens.Brown,Pens.Purple,Pens.IndianRed };
        Brush[] brushes = new Brush[7] {
            Brushes.AliceBlue,Brushes.Brown,Brushes.Purple,Brushes.IndianRed,
            Brushes.Black,Brushes.DarkGray,Brushes.Cyan
        };
        public 테트리스Form()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: Move(-1, 0); break;
                case Keys.Right: Move(1, 0); break;
                case Keys.Up: Turn(); ; break;
                case Keys.Space: MoveManyDown(); break;
            }

        }

        private void MoveManyDown()
        {
            while (Move(0, 1)) ;
        }

        private void NextBlcok()
        {
            diagram.SetXY(5, 0);
            Invalidate();
        }

        private void Turn()
        {
            diagram.Turn();
            Invalidate();
        }

        private bool Move(int cx, int cy)
        {
            bool check = false;
            if (board.CheckMoveEnable(diagram, cx, cy))
            {
                diagram.Move(cx, cy);
                check = true;
            }
            else
            {
                if (cy == 1)
                {
                    board.Add(diagram);
                    diagram.SetXY(5, 0);
                    if (board.CheckMoveEnable(diagram, 0, 0) == false)
                    {
                        tm_down.Enabled = false;
                        MessageBox.Show("게임 오버");
                        Close();
                    }
                }
            }
            Invalidate();
            return check;
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
            for (int cy = 0; cy < board.MAX_Y; cy++)
            {
                for (int cx = 0; cx < board.MAX_X; cx++)
                {
                    if (board.bdvals[cy, cx] != 0)
                    {
                        int index = board.bdvals[cy, cx] - 1;
                        Rectangle rect = new Rectangle(cx * step, cy * step, step, step);
                        graphics.DrawRectangle(pens[index], rect);
                        rect.X += 2;
                        rect.Y += 2;
                        rect.Width -= 4;
                        rect.Height -= 4;
                        graphics.FillRectangle(brushes[index], rect);
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

            for (int cy = 0; cy < 4; cy++)
            {
                for (int cx = 0; cx < 4; cx++)
                {
                    if (Diagram.bvalue[bn, tn, cy, cx] == 1)
                    {
                        Rectangle rect = new Rectangle((x + cx) * step, (y + cy) * step, step, step);
                        graphics.DrawRectangle(pens[bn], rect);
                        rect.X += 2;
                        rect.Y += 2;
                        rect.Width -= 4;
                        rect.Height -= 4;
                        graphics.FillRectangle(brushes[bn], rect);
                    }
                }
            }


        }

        private void tm_down_Tick(object sender, EventArgs e)
        {
            Move(0, 1);
        }

        private void tm_tm_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToShortTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToShortTimeString();

            int witdth = step * board.MAX_X + 18;
            int height = step * board.MAX_Y + 40;
            this.Size = new Size(witdth, height);


        }
    }
}
