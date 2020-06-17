using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 직렬화
{
    [Serializable]
    class Data
    {
        public string Name { get; private set; }
        public int Num { get; private set; }

        public Data(string name, int num)
        {
            Name = name;
            Num = num;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
