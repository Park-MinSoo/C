using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutObject
{
    class 오브젝트
    {
        static void Main(string[] args)
        {
            object obj=8;
            Console.WriteLine(obj);
            obj = '3';
            Console.WriteLine(obj);
            obj = "가나다";
            Console.WriteLine(obj);
            obj = 3.4;
            Console.WriteLine(obj);
            // obj는 모든 것의 기반이기 때문에 다 가능하다.

            var v = 8;
            Console.WriteLine(v);
            v = 'a';
            Console.WriteLine(v);
        }
    }
}
