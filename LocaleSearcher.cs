using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;

namespace 지역_검색
{
    public class LocaleSearcher
    {
        public List<Locale> Search(string query) 
        {
            List<Locale> list = new List<Locale>();
            string site = "https://openapi.naver.com/v1/search/local.xml";
            string query_str = string.Format("{0}?query={1}", site, query);
            WebRequest req = WebRequest.Create(query_str);
            req.Headers.Add("X-Naver-Client-Id:nr8oUuMRWTszpBFGgsp7");
            req.Headers.Add("X-Naver-Client-Secret:7YdkJgiTPr");
            WebResponse res = req.GetResponse();
            Stream stream = res.GetResponseStream();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(stream);
            XmlNode rnode = xdoc.SelectSingleNode("rss");
            XmlNode cnode = rnode.SelectSingleNode("channel");
            XmlNodeList its = cnode.SelectNodes("item");
            foreach(XmlNode inode in its)
            {
                Locale locale = MakeLocale(inode);
                list.Add(locale);
            }
            return list;
        }

        private Locale MakeLocale(XmlNode inode)
        {
            string title = inode.SelectSingleNode("title").InnerText;
            title = RemoveTag(title);
            string mapx = inode.SelectSingleNode("mapx").InnerText;
            string mapy = inode.SelectSingleNode("mapy").InnerText;
            return new Locale(title, mapx, mapy);
        }

        private string RemoveTag(string title)
        {
            int si = title.IndexOf('<');
            int ei = title.IndexOf('>');
            while((si!=-1)&&(si<ei))
            {
                string pre = title.Substring(0, si);
               // string middle = title.Substring(si + 1, ei - si - 1);
                string post = title.Substring(ei + 1);
                title = pre + post;
                si = title.IndexOf('<');
                ei = title.IndexOf('>');
            }
                return title;
            }
        }
    }
