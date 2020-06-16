using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 대리자_소개
{
    delegate int MyDelete(int a, int b);
    class 대리자
    {
        static void Main(string[] args)
        {
            MyDelete dele = Add;
            int re = dele(3, 4);
            Console.WriteLine("결과 : {0}",re);

            MyDelete dele2 = Sub;
            int re2 = dele2(3, 4);
            Console.WriteLine("결과 : {0}", re2);
        }
        static int Add(int a,int b)
        {
            Console.WriteLine("Add 메서드");
            return a + b;
        }
        static int Sub(int a, int b)
        {
            Console.WriteLine("Sub 메서드");
            return a - b;
        }
    }
}
