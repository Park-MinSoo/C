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
            int dx = diagram.X+cx;
            int dy = diagram.Y+cy;
            int bn = diagram.BN;
            int tn = diagram.TN;

            for (int x=0;x<4;x++)
            {
                for(int y=0;y<4;y++)
                {   
                    if(((dy+y)>=20)||((dx+x)<0)||((dx+x)>=10))
                    {
                        if((Diagram.bvalue[bn, tn, y, x] == 1))
                        {
                            return false;
                        }
                    }
                    if((Diagram.bvalue[bn,tn,y,x]==1) && (bdvals[dy+y,dx+x]==1))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
