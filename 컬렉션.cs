using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 사용자_정의_컬렉션
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberCollection mc = new MemberCollection();
            mc.AddMember(new Member("홍길동", 3));
            mc.AddMember(new Member("강감찬", 2));
            foreach (Member member in mc)
            {
                Console.WriteLine(member);
            }
        }
    }
}
