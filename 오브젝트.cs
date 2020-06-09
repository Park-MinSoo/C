using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutObject
{
    class Foo
    {
        public int Value;

        public Foo(int v)
        {
            Value = v;
        }
        public override string ToString()   // override를 통한 ToString 재정의
        {
            return Value.ToString();
        }
    }
    class 오브젝트
    {
        static void Main(string[] args)
        {
            object obj=8;
            Console.WriteLine(obj);
            obj = '3';
            Console.WriteLine(obj);
            obj = "가나다";
            Console.WriteLine(obj);
            obj = 3.4;
            Console.WriteLine(obj);
            // obj는 모든 것의 기반이기 때문에 다 가능하다.

            var v = 8;  // var은 아직 타입을 명시하지 않은 것이다. 주로 script 언어에서 쓰인다.
            Console.WriteLine(v);
            v = 'a';
            Console.WriteLine(v);

            int i = 2, j = 2;

            Console.WriteLine(object.Equals(i, j)); // 같다.
            Console.WriteLine(object.ReferenceEquals(i, j));    
            // 다르다. (해당 표현의 메모리가 같은지 or 다른지를 보기 때문이다.)

            string s1 = string.Format("Hello"); // string.Format은 내가 원하는 문자열 형식을 지정 해 줄 수 있다.
            string s2 = string.Format("Hello");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(object.Equals(s1,s2));
            Console.WriteLine(object.ReferenceEquals(s1, s2));

            string s3 = "Yahoo";
            string s4 = "Yahoo";

            Console.WriteLine(object.Equals(s3, s4));
            Console.WriteLine(object.ReferenceEquals(s3, s4));
            // 이경우에는 true 라고 출력된다. 즉, 이는 s3과 s4가 같은 메모리를 가르키고 있다 라는것을 알 수 있다.

            Foo f1 = new Foo(3);
            Foo f2 = new Foo(3);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(object.Equals(f1, f2));
            Console.WriteLine(object.ReferenceEquals(f1, f2));  
            // 안에 있는 값이 같아도, 참조하는 메모리가 다르면 다른값이라고 출력되어진다.
            // 쉽게 Equals 는 값만 을 보는 것. ReferenceEquals는 하나의 동일한 생명체인지 보면 쉽다.

        }
    }
}
