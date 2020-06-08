using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정수_사이_합
{
    class 정수_사이_합
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int total = 0;

            Console.Write("첫 번째 값을 입력하세요 :");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("두 번째 값을 입력하세요 :");
            num2 = int.Parse(Console.ReadLine());

            if(num1 <  num2)
            {
                while (++num1 < num2) 
                {
                    total = total + num1;
                }
            }

            else if (num1 > num2)
            {
                while (num1 > ++num2)
                {
                    total = total + num2;
                }
            }

            Console.WriteLine("두 정수 사이의 합은 {0} 입니다", total);
            
        }
    }
}
