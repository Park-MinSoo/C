using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutStreamFormat
{
    class Lab1
    {
        static void Main(string[] args)
        {
            int i = 123;
            string s = "홍길동";
            double df = 3.45;
            Console.WriteLine("{0,10}{1}{2}{0}",i,s,df);
            // i,s,df가 index에 맞추어 {매개변수 순서,출력할 자릿수} 자리에 할당이 된다.

            Console.WriteLine("{0:000000}", 12345); // 0의 갯수
            Console.WriteLine("{0:D6}", 12345); // D 정수
            Console.WriteLine("{0:.0}", 12345.6789);  // 0의 갯수
            Console.WriteLine("{0:N2}", 12345.6789);  // N 정수
            Console.WriteLine("{0:F3}", 12345.6789);  // F 정수

        }
    }
}
