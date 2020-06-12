using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속과_다형성
{
    class Musician   // sealed를 class 앞에 붙이게 되면, 기반 형식으로 사용 못하게 된다. (봉인 하는 것)
    {
        int mnum;
        internal Musician(int mnum)
        {
            this.mnum = mnum;
            Console.WriteLine("{0}번 음악가 바흐",mnum);
        }
        protected int MNum  // protected는 다른 곳에서는 사용을 못하지만 자신을 상속받고 있는곳에서는 사용이 가능하다.
        {
            get
            {
                return mnum;
            }
        }
        internal void Play()
        {
            Console.WriteLine("랄랄라~");
        }
    }
}
