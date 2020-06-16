using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace 지역_검색
{
    class LocaleSearcher2
    {
        public List<Locale> Search(string query)
        {
            List<Locale> list = new List<Locale>();
            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string query_str = string.Format("{0}?query={1}", site, query);
            WebRequest request = WebRequest.Create(query_str);
            string header = "KakaoAK " + rkey;
            request.Headers.Add("Authorization", header);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            String json = reader.ReadToEnd();
            stream.Close();

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic dob = js.Deserialize<dynamic>(json);
            dynamic docs = dob["documents"];
            object[] buf = docs;
            int length = buf.Length;
            for (int i = 0; i < length; i++)
            {
                Locale locale = MakeLocale(docs, i);
                list.Add(locale);
            }

            return list;
        }
      
        private Locale MakeLocale(dynamic docs, int i)
        {
            string title = docs[i]["place_name"];
            string lng = docs[i]["x"];
            string lat = docs[i]["y"];
            return new Locale(title, lat, lng);
        }

        //
    }
}
