using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 메뉴_제어하기
{
    class 메뉴_제어
    {
        static void Main(string[] args)
        {
            메뉴_제어_Application app = new 메뉴_제어_Application();    // Ctrl + . 을 Application에서 누른 후 새파일에서 생성을 입력.
            app.init();
            app.Run();
            app.Exit();
        }
    }
}
