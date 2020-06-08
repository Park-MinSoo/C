using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 랜덤_값_맞추기
{
    class 랜덤_값_맞추기
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int rvalue = rand.Next(900) + 100; //랜덤 값 설정
            int num = 0;
            while (true)    // 반복(참일때)
            {
                Console.Write("입력:");   
                num = int.Parse(Console.ReadLine());    // 입력을 int에 정수형으로 변환하여 담음
                if(num < rvalue)
                {
                    Console.WriteLine("입력 숫자보다 높습니다.");
                }
                else if(num > rvalue)
                {
                    Console.WriteLine("입력 숫자보다 낮습니다.");
                }
                else
                {
                    Console.WriteLine("정답 입니다.");
                    break;  //끝
                }
            }
        }
    }
}
