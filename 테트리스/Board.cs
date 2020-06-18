using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 테트리스
{
    class Board
    {
        const int max_x = 10;
        const int max_y = 20;
        internal int[,] bdvals = new int[max_y, max_x];
        internal int MAX_X
        {
            get
            {
                return max_x;
            }
        }
        internal int MAX_Y
        {
            get
            {
                return max_y;
            }
        }

        internal bool CheckMoveEnable(Diagram diagram, int cx, int cy)
        {
            int dx = diagram.X + cx;
            int dy = diagram.Y + cy;
            int bn = diagram.BN;
            int tn = diagram.TN;

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (((dy + y) >= 20) || ((dx + x) < 0) || ((dx + x) >= 10))
                    {
                        if (Diagram.bvalue[bn, tn, y, x] == 1)
                        {
                            return false;
                        }
                    }
                    if ((Diagram.bvalue[bn, tn, y, x] == 1) && (bdvals[dy + y, dx + x] != 0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        internal void Add(Diagram diagram)
        {
            int dx = diagram.X;
            int dy = diagram.Y;
            int bn = diagram.BN;
            int tn = diagram.TN;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (((dy + y) >= 20) || ((dx + x) < 0) || ((dx + x) >= 10))
                    {
                    }
                    else if (Diagram.bvalue[bn, tn, y, x] == 1)
                    {
                        bdvals[dy + y, dx + x] = bn + 1;
                    }
                }
            }


            int cl = dy + 3;
            for (int cc = 0; cc < 4; cc++)
            {
                if (CheckLine(cl) == false)
                {
                    cl--;
                }
            }

        }

        private bool CheckLine(int cl)
        {
            if (cl >= 20)
            {
                return false;
            }
            for (int i = 0; i < max_x; i++)
            {
                if (bdvals[cl, i] == 0)
                {
                    return false;
                }
            }
            ClearLine(cl);
            return true;
        }
        private void ClearLine(int cl)
        {
            for (int y = cl; y > 0; y--)
            {
                for (int x = 0; x < max_x; x++)
                {
                    bdvals[y, x] = bdvals[y - 1, x];
                }
            }
        }
    }
}
