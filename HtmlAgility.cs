using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HtmlAgility_연습
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            string result = wc.DownloadString("https://naver.com");
            HtmlDocument hdoc = new HtmlDocument();
            hdoc.LoadHtml(result);
        //    Console.WriteLine(hdoc.Text);
            HtmlNode head_hn = hdoc.DocumentNode.SelectSingleNode("//head");
            HtmlNode t_hn = head_hn.SelectSingleNode("//title");
            Console.WriteLine(t_hn.InnerText);
            Console.WriteLine("=========================");
            HtmlNode hn = hdoc.DocumentNode.SelectSingleNode("//body");
        //    Console.WriteLine(hn.InnerText);


        }
    }
}
