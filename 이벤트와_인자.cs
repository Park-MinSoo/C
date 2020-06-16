using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이벤트와_인자
{
    class 이벤트와_인자
    {
        static void Main(string[] args)
        {
            EventManager manager = new EventManager();
            manager.Riched += Manager_Riched;
            manager.Input(4);
            manager.Input(20);
            manager.Input(200);
            manager.Input(402);
            manager.Input(14);
            manager.Input(194);
            manager.Input(20);
            manager.Input(194);
            manager.Input(20);
        }

        private static void Manager_Riched(object sender, RichedEventArgs e)
        {
            Console.WriteLine("이제 부자다.{0}",e.Total);
            foreach(int money in e.InputList)
            {
                Console.WriteLine(money);
            }

        }
    }
}
