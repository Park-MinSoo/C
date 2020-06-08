using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 약수_판별
{
    class 약수_판별
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.Write("첫 번째 값을 입력하세요 :");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("두 번째 값을 입력하세요 :");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("두 번째 값이 더 큽니다.");
                if (num2 % num1 == 0) { 
                    Console.WriteLine("그리고 {0}은 {1}의 약수입니다.",num1, num2);
                }
                else
                {
                    Console.WriteLine("그리고 {0}은 {1}의 약수가 아닙니다.", num1, num2);
                }
            }
            else if (num1 > num2)
            {
                Console.WriteLine("첫 번째 값이 더 큽니다.");
                if (num1 % num2 == 0)
                {
                    Console.WriteLine("그리고 {0}은 {1}의 약수입니다.", num2, num1);
                }
                else
                {
                    Console.WriteLine("그리고 {0}은 {1}의 약수가 아닙니다.", num2, num1);
                }
            }
            else
            {
                Console.WriteLine("두 값이 동일합니다.");
            }
        }
    }
}
