using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 데이터_관리
{
    public class DataManager
    {
        Dictionary<int, MyData> mdic = new Dictionary<int, MyData>();
        static DataManager dm = new DataManager();
        //List<MyData> list = new List<MyData>();
        //ArrayList list - new ArrayList();
        public static DataManager DM
        {
            get
            {
                return dm;
            }
        }
        DataManager()
        {
        }
        public int SeqNo
        {
            get;
            private set;
        }
        public MyData this[int no]
        {
            get
            {
                return mdic[no];
            }
        }
        public bool Contains(int no)
        {
            return mdic.ContainsKey(no);
       }
        public void Add(int no, string title, string des)
        {
            mdic[no] = new MyData(no, title, des);
            SeqNo++;
        }

        public void Modify(int no, string title, string des)
        {
            if(Contains(no)==false)
            {
                return;
            }
            MyData md = mdic[no];
            md.Title = title;
            md.Des = des;
        }
    }
}
