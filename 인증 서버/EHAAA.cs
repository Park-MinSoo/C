using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EHAAALib
{
    public class EHAAA:MarshalByRefObject
    {
        DataTable mtb = new DataTable("회원");
        Dictionary<string, DateTime> dt_dic = new Dictionary<string, DateTime>();
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

        Timer timer = null;

        void CheckKeepAlive(object state)
        {
            Console.WriteLine(".");

            List<string> dlist = new List<string>();
            foreach(KeyValuePair<string,DateTime> sd in dt_dic)
            {
                TimeSpan ts = DateTime.Now - sd.Value;
                if(ts.TotalSeconds > 9) //9초 동안 응답이 없으면
                {
                    Logout(sd.Key); // 강제로 로그아웃 시킨다.
                    dlist.Add(sd.Key);
                    //dt_dic.Remove(sd); 를 해버리면 foreach 구문에서는 원소의 값의 변경만 가능하지 추가나 제거하면 예외처리가 발생하게된다.
                }
            }

            foreach(string id in dlist)
            {
                dt_dic.Remove(id);
            }
        }

        public void KeepAlive(string id)
        {
            try     // 블랙해커가 만일 로그인되지 않은 아이디를 KeepAlive 보냈을 경우를 막기 위해 try-catch를 사용하는것이다.
            {
                dt_dic[id] = DateTime.Now;
            }
            catch { }   // 이때 catch할때는 할일이 없기 때문에 비어있는 것.
        }

        public void Logout(string id)
        {
            try
            {
                DataRow dr = mtb.Rows.Find(id);
                dr["status"] = 0;
            }
            catch
            {

            }
        }

        private void Initialize()
        {
            timer = new Timer(CheckKeepAlive);
            timer.Change(0, 3000);  // 0초 부터 발생하여, 3초 주기로 준다.

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
                    dt_dic[id] = DateTime.Now;  // 로그인할때 현재 시각 정보를 넣어줌.
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
