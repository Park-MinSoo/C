using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도형_실습
{
    public class DrawMain
    {
        
        static void Main(string[] args)
        {
            {
                DiagramDraw dd = DiagramDraw.Sigleton;
                dd.Run();
            }
        }
    }
}
