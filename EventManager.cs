using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이벤트와_인자
{
    class EventManager
    {
        public event RichedEventHandler Riched;
        List<int> list = new List<int>();
        int total = 0;

        public void Input(int money)
        {
            list.Add(money);
            total += money;
            if(total >=1000)
            {
                Riched(this, new RichedEventArgs(list, total));
                total = 0;
                list = new list<int>();
            }

        }
    }

    internal class list<T> : List<int>
    {
    }
}
