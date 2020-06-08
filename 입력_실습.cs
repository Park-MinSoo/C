using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 입력_실습
{
    class 입력_실습
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("정수:");
            string instr = Console.ReadLine();
            // i = int.Parse(instr);  // 문자열을 int 형으로 변환 하였다.
            if (int.TryParse(instr, out i))
            { 
                Console.WriteLine("입력한 값은 {0}입니다.", i);
            }
            else
            {
                Console.WriteLine("잘못 입력하였습니다.");
            }
        }
    }
}
