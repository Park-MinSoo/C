using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속과_다형성
{
    class Drummer:Musician
    {
        internal Drummer(int mnum):base(mnum)
        {
            Console.WriteLine("드러머 뚱땅뚱땅");
        }
        internal void Polling()
        {
            Console.WriteLine("{0}번 음악가 드럼 스틱을 빙빙~",MNum);
        }
    }
}
