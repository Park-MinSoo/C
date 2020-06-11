using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 유닛응용
{
    class Program
    {
        static void Main(string[] args)
        {
            MyApplication myap = MyApplication.Singleton;
            myap.Init();
            myap.Run();
            myap.Exit();
        }
    }
}
