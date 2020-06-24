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
            mtb.Rows.Add(dc_pw);
            DataColumn dc_status = new DataColumn("status", typeof(int));
            dc_status.DefaultValue = 0;
            mtb.Rows.Add(dc_status);
            DataColumn dc_ip = new DataColumn("ip", typeof(IPAddress));
            mtb.Rows.Add(dc_ip);

            // 숏메세지 포트
            DataColumn dc_sp = new DataColumn("sp", typeof(int));
            mtb.Rows.Add(dc_sp);

            // 파일 포트
            DataColumn dc_fp = new DataColumn("sp", typeof(int));
            mtb.Rows.Add(dc_fp);

            //콜백 포트
            DataColumn dc_bp = new DataColumn("sp", typeof(int));
            mtb.Rows.Add(dc_bp);

            mtb.WriteXmlSchema(sfname);
        }

        
    }
}
