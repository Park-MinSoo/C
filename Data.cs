using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 사용자_정의_형식_보관
{
    class Data:IComparable<Data>// IComparable은 분류기준에 대하여 어떻게 할지 설정해주는것이므로 오직 1가지만 존재한다.
    {
        public int Num { get; private set; }
        public string Name { get; private set; }
        public Data(int num, string name)
        {
            Num = num;
            Name = name;
        }
        public override string ToString()
        {
            return string.Format("{0},{1}",Num,Name);
        }
        public int CompareTo(Data other)
        {
           return Num - other.Num;
           // return Name.CompareTo(other.Name);
        }
    }
    public class DataCompapreByNum:IComparer<Data>  // IComparer는 여러개가 존재 할 수 있으며 다양한 분류 기준을 더 설정해 주는 것이다.
    {
        public int Compare(Data x, Data y)
        {
            return x.Num - y.Num;
        }
    }
}
