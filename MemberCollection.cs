using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 사용자_정의_컬렉션
{
   public class MemberCollection:IEnumerable
    {
        List<Member> members = new List<Member>();
        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public IEnumerator GetEnumerator()
        {
            return members.GetEnumerator();
        }
    }
}
