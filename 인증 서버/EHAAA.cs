using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EHAAALib
{
    public class EHAAA:MarshalByRefObject
    {
        DataTable mtb = new DataTable("회원");
        public EHAAA()
        {
            Initialize();
        }

        ~EHAAA()    // 소멸자 (가비지 컬랙터가 수행한다.)
        {
            foreach(DataRow dr in mtb.Rows)
            {
                dr["status"] = 0;   // 종료하는 때에 로그인 상태를 전부 0 으로 만들어준다.
            }
            mtb.WriteXml(dfname); // 개체가 소멸될때 해야 할 일
        }

        const string sfname = "member.xsl"; //스키마 파일
        const string dfname = "member.xml"; // 데이터 파일
        private void Initialize()
        {
            if (File.Exists(sfname))
            {
                mtb.ReadXmlSchema(sfname);
                if(File.Exists(dfname))
                {
                    mtb.ReadXml(dfname);
                }
            }
            else
            {
                DesingMTB();
            }
        }

        private void DesingMTB()
        {
            DataColumn dc_id = new DataColumn("id", typeof(string));
            dc_id.Unique = true;
            dc_id.AllowDBNull = false;  // 개체 무결성
            mtb.Columns.Add(dc_id);
            DataColumn dc_pw = new DataColumn("pw", typeof(string));
            dc_pw.AllowDBNull = false;
            mtb.Columns.Add(dc_pw);
            DataColumn dc_status = new DataColumn("status", typeof(int));
            dc_status.DefaultValue = 0;
            mtb.Columns.Add(dc_status);
            DataColumn dc_ip = new DataColumn("ip", typeof(IPAddress));
            mtb.Columns.Add(dc_ip);

            // 숏메세지 포트
            DataColumn dc_sp = new DataColumn("sp", typeof(int));
            mtb.Columns.Add(dc_sp);

            // 파일 포트
            DataColumn dc_fp = new DataColumn("fp", typeof(int));
            mtb.Columns.Add(dc_fp);

            //콜백 포트
            DataColumn dc_bp = new DataColumn("bp", typeof(int));
            mtb.Columns.Add(dc_bp);

            DataColumn[] pkeys = new DataColumn[] { dc_id };
            mtb.PrimaryKey = pkeys;

            mtb.WriteXmlSchema(sfname);
        }

        public bool join(string id, string pw)
        {
            try 
            {
                DataRow dr = mtb.NewRow();
                dr["id"] = id;
                dr["pw"] = pw;
                mtb.Rows.Add(dr);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public int Login(string id, string pw)
        {
            try
            { 
                DataRow dr = mtb.Rows.Find(id);
                if(dr==null)
                {
                    return 1;   // 미가입 ID
                }
                if((int)dr["status"]==0)
                {
                   dr["status"] = 1;
                   return 0;    // 로그인 성공
                }
                return 2;   // 이미 로그인 중
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 3;   // 예외 발생
            }
        }
    }
}
