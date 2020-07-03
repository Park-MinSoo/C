using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSelectorLib
{
    public delegate void ChangeColorEventHandler(object sender, ChangeColorEventArgs e);
    public class ChangeColorEventArgs:EventArgs
    {
        public int Red
        {
            get;
            private set;
        }
        public int Green
        {
            get;
            private set;
        }
        public int Blue
        {
            get;
            private set;
        }

        public Color Color
        {
            get
            {
                return Color.FromArgb(Red, Green, Blue);
            }
        }
        public ChangeColorEventArgs(int r, int g, int b)
        {
            Red = r;
            Green = g;
            Blue = b;
        }
    }
}
