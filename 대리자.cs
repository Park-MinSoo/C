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
            Console.WriteLine("결과 : {0}", re);

            MyDelete delee = Sub;
            int re2 = delee(3, 4);
            Console.WriteLine("결과 : {0}", re2);

            Manager man = new Manager();
            man.dele += Man_dele;
            Console.WriteLine("1");
            man.Dolt(4);
            Console.WriteLine("2");
            man.Dolt(5);
            Console.WriteLine("3");
            man.Dolt(9);
            Console.WriteLine("4");
            man.Dolt(3);
            Console.WriteLine("5");
            man.Dolt(20);
            Console.WriteLine("6");
        }

        private static void Man_dele()
        {
            Console.WriteLine("사건발생");
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
