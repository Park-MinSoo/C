using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 직렬화
{
    [Serializable]
    class DataManager:IEnumerable
    {
        List<Data> datas = new List<Data>();
        public void Add(string name, int num)
        {
            datas.Add(new Data(name, num));
        }

        public IEnumerator GetEnumerator()
        {
            return datas.GetEnumerator();
        }
    }
}
