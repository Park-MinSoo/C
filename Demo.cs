using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class Demo
    {
        public int Num
        {
            get;
            private set;
        }
        public string Name
        {
            get; private set;
        }
        public Demo(int num, string name)
        {
            Num = num;
            Name = name;
        }
        public void Foo(int a)
        {
            Console.WriteLine("Foo:{0}", a);

        }
        public int Add(int a, int b)
        {
            Soo(a, b);
            Console.WriteLine("ADD");
            return a + b;
        }
        public static void Hello(string msg)
        {
            Console.WriteLine("안녕{0}", msg);
        }
        private void Soo(int a, int b)
        {
            Console.WriteLine("ADD");
        }
    }
}