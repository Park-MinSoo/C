using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열
{
    class 도서_배열
    {
        static void Main(string[] args)
        {
            도서_번호_배열_Application app = new 도서_번호_배열_Application();
            app.init();
            app.Run();
            app.Exit();
        }
    }
}
