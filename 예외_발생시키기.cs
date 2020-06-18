using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예외_처리
{
    class 예외_발생시키기
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1");
                int[] arr = new int[10];    // 0 ~ 9 까지 배열이므로
                Console.WriteLine("2");
                arr[10] = 9;    // 오류가 발생하게 된다.
                Console.WriteLine("3");
            }
            catch (Exception ex)
            {
                Console.WriteLine("예외가 발생하였습니다.");
            }
                Console.WriteLine("d");
            }
    }
}
