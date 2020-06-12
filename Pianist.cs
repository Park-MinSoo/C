using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속과_다형성
{
    class Pianist : Musician
    {
        internal Pianist(int mnum):base(mnum)
        {
            Console.WriteLine("피아니스트 이루마");
        }
        internal void Tuning()
        {
            Console.WriteLine("{0}피아니스트 조율", MNum);
        }
    }
}
