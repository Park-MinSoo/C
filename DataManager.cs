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
            get
            {
                return 0;
            }
        }
        public MyData this[int no]
        {
            get
            {
                return null;
            }
        }
        public bool Contains(int no)
        {
            return false;
        }
        public void Add(int no, string title, string des)
        {
            
        }

        public void Modify(int no, string title, string des)
        {
            
        }
    }
}
