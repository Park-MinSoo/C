using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스와_컬렉션
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            //stu.Study();
            GoToLibrary(stu);
            Student2 stu2 = new Student2();
            stu2.Study();
            GoToLibrary(stu);
        }

        private static void GoToLibrary(IStudy istudy)
        {
            istudy.Study();
        }
    }
}
