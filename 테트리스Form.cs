﻿using System;
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
                case Keys.Down: Move(0,1); break;
            }
        }

        private void Turn()
        {
            diagram.Turn();
            Invalidate();
        }

        private void Move(int cx, int cy)
        {
            diagram.Move(cx, cy);
            Invalidate();   // 다시그려주세요
        }

        const int step = 30;
        Diagram diagram = new Diagram(5, 0);


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            DrawDiagram(graphics);
        }

        private void DrawDiagram(Graphics graphics)
        {
            int tn = diagram.TN;
            int x = diagram.X;
            int y = diagram.Y;
            for (int cy=0;cy<4;cy++)
            {
                for(int cx=0;cx<4;cx++)
                {
                    if(Diagram.bvalue[tn,cy,cx]==1)
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
        }
    }
}
