using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예외_던지기
{
    class 예외_던지기
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Main-1"); Foo();
                Console.WriteLine("Main-2");
            }
            catch(ApplicationException ex)
            {
                Console.WriteLine("응용 예외 발생");
                Console.WriteLine(ex.Message);
            }
            catch(SystemException ex)
            {
                Console.WriteLine("시스템 예외 발생");
                Console.WriteLine(ex.Message);

            }
            catch(Exception ex) // 얘는 모든 Exception을 다 먹어 버리므로 맨 마지막에 나와야 한다.
            {
                Console.WriteLine("예외 발생");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);   // 예외가 어디서 났는지 추적함
                Console.WriteLine("도움말:{0}",ex.HelpLink);

            }
        }

        private static void Foo()
        {
            Console.WriteLine("Foo-1");  Soo();
            Console.WriteLine("Foo-2");  Zoo();
            Console.WriteLine("Foo-3");
        }

        private static void Soo()
        {
            Console.WriteLine("Soo-1");
        }

        private static void Zoo()
        {
            Console.WriteLine("Zoo-1");
            Exception ex = new Exception("Zoo에서 던진 돌");
            ex.HelpLink = "https://ehpub.co.kr";
            throw ex;
        }
    }
}
