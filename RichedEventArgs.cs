using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이벤트와_인자
{
    public delegate void RichedEventHandler(object sender, RichedEventArgs e);

    public class RichedEventArgs:EventArgs
    {
        public List<int> inputList
        {
            get;
            private set;
        }
        public List<int> InputList { get; }
        public int Total
        {
            get;
            private set;
        }
        public RichedEventArgs(List<int> il, int total)
        {
            InputList = il;
            Total = total;
        }
        public override string ToString()
        {
            return Total.ToString();
        }
    }
}
