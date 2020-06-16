using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 비동기_대리자
{
    class 비동기_대리자
    {
        delegate void MyDele();
        static void Main(string[] args)
        {
            // Foo();
            MyDele dele = Foo;
            dele.BeginInvoke(EndFoo, null);
            int i = 0;
            for(i=0;i<200;i++)
            {
                Console.WriteLine("Main:{0}",i) ;
                Thread.Sleep(rand.Next(1000));
            }
        }
        static void EndFoo(IAsyncResult iar)
        {

            Console.WriteLine("Foo 작업 끝");
       /*     AsyncResult ar = iar as AsyncResult;
            MyDele dele = ar.AsyncDelegate as MyDele;
            int re = dele.EndInvoke(iar);
            Console.WriteLine("결과:{0}",re);*/
        }
        static Random rand = new Random();
        static void /*int*/ Foo()
        {
            int i = 0;
            for(i=0;i<100;i++)
            {
                Console.WriteLine("Foo:{0}",i);
                    Thread.Sleep(rand.Next(1000));
            }
          //  return 100;
        }
    }
}
