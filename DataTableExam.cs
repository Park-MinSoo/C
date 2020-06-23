using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Table_연습
{
    class DataTableExam
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable("회원");
            DesignTable(dt);
            AddData(dt, "홍길동", 23);
            AddData(dt, "강감찬", 12);
            dt.WriteXml("data.xml");    // WriteXml은 데이터를 저장.
            dt.WriteXmlSchema("data.xsl");  // WriteXmlSchema 는 데이터 구조 자체를 저장.
            ///////////////////////////
            DataTable dt2 = new DataTable();
            dt2.ReadXmlSchema("data.xsl");
            dt2.ReadXml("data.xml");
            foreach(DataRow dr in dt2.Rows)
            {
                Console.WriteLine("{0},{1}", dr["아이디"], dr["나이"]);
            }
        }

        private static void AddData(DataTable dt, string id, int age)
        {
            DataRow dr = dt.NewRow();
            dr["아이디"] = id;
            dr["나이"] = age;
            dt.Rows.Add(dr);    //Rows.Add로 추가를 해주어야 들어가게된다.
        }

        private static void DesignTable(DataTable dt)
        {
            DataColumn dc = new DataColumn("아이디", typeof(string));
            dc.AllowDBNull = false;
            dc.Unique = true;
            dt.Columns.Add(dc);
            DataColumn dc_age = new DataColumn("나이", typeof(int));
            dc_age.DefaultValue = -1;
            dt.Columns.Add(dc_age);

        }
    }
}
