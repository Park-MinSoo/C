using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 매개변수_전달_방식
{
    class 매개변수_전달_방식
    {
        static void Main(string[] args)
        {
            int iq = 200;
            Study(iq, 3);
            Console.WriteLine("아이큐 : {0}", iq);
        }

        private static void Study(int iq, int v)
        {
            Console.WriteLine("{0}시간 공부", v);
            iq += v;
            Console.WriteLine("Study : {0}", iq);
        }
    }
}
