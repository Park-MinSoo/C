using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 사용자_정의_컬렉션
{
    public class Member
    {
        public String Name { get; private set; }

        public int Num { get; private set; }

        public Member(string name, int num)
        {
            Name = name;
            Num = num;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
