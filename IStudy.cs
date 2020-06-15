using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스와_컬렉션
{
    interface IStudy
    {
        void Study();
    }
    class Student : IStudy
    {
        void IStudy.Study()
        {
            Console.WriteLine("공부하다");
        }
    }
    class Student2 : IStudy
    {
        public void Study()
        {
            Console.WriteLine("공부하다");
        }
    }
}
