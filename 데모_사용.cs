using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 데모_사용
{
    class 데모_사용
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load("DemoLib");
            Console.WriteLine("성공");

            /*Type[] types = asm.GetTypes();
            foreach(Type type in types)
            {
                Console.WriteLine(type);
            }*/

            Type demo_type = asm.GetType("DemoLib.Demo");
            //Console.WriteLine(demo_type);


            /*PropertyInfo[] pis = demo_type.GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                Console.WriteLine(pi);
                // Num이라는 Property 와 Name이라는 Property가 있다는것을 확인 할 수 있다.
            }
*/


/*
            MethodInfo[] mis = demo_type.GetMethods();
            foreach (MethodInfo mi in mis)
            {
                Console.WriteLine(mi);
            }
*/

            object[] param = new object[] { 27, "홍길동" };
            object demo_ins = Activator.CreateInstance(demo_type, param);
            Console.WriteLine(demo_ins);

            PropertyInfo pi_num = demo_type.GetProperty("Num");
            int num = (int)pi_num.GetValue(demo_ins);
            Console.WriteLine("번호:{0}",num);

            MethodInfo mi = demo_type.GetMethod("Foo");
            object[] pc = new object[] { 3 };
            mi.Invoke(demo_ins, pc);

            MethodInfo mi_h = demo_type.GetMethod("Hello");
            object[] pch = new object[] { "음냐뤼" };
            mi_h.Invoke(null,pch);
        }
    }
}
