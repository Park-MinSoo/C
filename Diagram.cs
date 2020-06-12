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

        public abstract void Draw();
        internal virtual int GetID()
        {

            return id;
        }
    }
}
