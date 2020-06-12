using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 도형_실습
{
    public abstract class Diagram
    {
        readonly int id = 0;
        static int lastid;
        public int ID
        {
            get
            {
                return id;
            }
        }
        public Diagram()
        {
            lastid++;
            id = lastid;
        }

        public abstract void Draw();    // 추상적인 Draw 메서드를 만들고 상속받는 클래스 마다 다시 Draw 메서드를 오버라이딩 해준다.
        internal virtual int GetID()
        {
            return id;
        }
    }
}
