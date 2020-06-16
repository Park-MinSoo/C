using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 대리자_소개
{
    class Manager
    {
        public event MyDele2 dele;
        public int Sum { get; private set; }
        public void Dolt(int a)
        {
            for(int i = 0;i<a;i++)
            {
                Sum += i;
                if(Sum >=100)
                {
                    dele();
                    Sum = 0;
                }
            }
        }
    }
}
