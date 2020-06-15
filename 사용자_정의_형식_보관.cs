using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 사용자_정의_형식_보관
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Data> datas = new List<Data>();
            datas.Add(new Data(3, "홍길동"));
            datas.Add(new Data(4, "김길동"));
            datas.Add(new Data(2, "박길동"));

            datas.Add(new Data(7, "최길동"));
            datas.Add(new Data(1, "주길동"));
            datas.Sort();   // 이대로만 하면 이름순 정렬인지, 숫자순 정렬인지 모르기 때문에 정렬되지 않는다.
            foreach (Data data in datas)

            {
                Console.WriteLine(data);
            }
            Console.WriteLine("========");
            datas.Sort(new DataCompapreByNum());
            foreach (Data data in datas)
            {
                Console.WriteLine(data);
            }


        }
    }
}
