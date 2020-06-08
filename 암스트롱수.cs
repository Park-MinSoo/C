using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 암스트롱수
{
    class 암스트롱수
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int num = 0;

            Console.Write("세 자리 수를 입력하세요 :");
            num = int.Parse(Console.ReadLine());

            a = num / 100;
                //Console.WriteLine("a 값 : {0}.",a);
            b = (num - a * 100) / 10;
                //Console.WriteLine("b 값 : {0}.",b);
            c = (num - a * 100 - b * 10) / 1;
                //Console.WriteLine("c 값 : {0}.",c);

            if ( num == (a*a*a) + (b*b*b) + (c*c*c))
            {
                Console.WriteLine("입력하신 세자리수는 암스트롱 수 입니다.");
            }
            else
            {
                Console.WriteLine("입력하신 세자리수는 암스트롱 수가 아닙니다.");
            }
        }
    }
}
