using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 이웃_도서_검색
{
    class 이웃_도서_검색
    {
        static void Main(string[] args)
        {
            Console.Write("검색어:");
            string query = Console.ReadLine();

            string site = "https://openapi.naver.com/v1/search/book.xml?query=";
            string qstr = string.Format("{0}{1}",site,query);
            Console.WriteLine("쿼리문자열 :{0}",qstr);

            WebRequest req = WebRequest.Create(qstr);
            req.Headers.Add("X-Naver-Client-Id:nr8oUuMRWTszpBFGgsp7");
            req.Headers.Add("X-Naver-Client-Secret:7YdkJgiTPr");
            
            WebResponse res = req.GetResponse();
            Stream stream = res.GetResponseStream();

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(stream);

            XmlNode rssnode = xdoc.SelectSingleNode("rss");
            XmlNode cnode = rssnode.SelectSingleNode("channel");
            XmlNodeList inodes = cnode.SelectNodes("item");

            List<Book> books = new List<Book>();
            foreach(XmlNode inode in inodes)
            {
                Book book = MakeBook(inode);
                books.Add(book);
            }
            foreach(Book book in books)
            {
                ViewBook(book);
            }
        }

        private static Book MakeBook(XmlNode inode)
        {
            string title = inode.SelectSingleNode("title").InnerText;
            string author = inode.SelectSingleNode("author").InnerText;
            int price = int.Parse(inode.SelectSingleNode("price").InnerText);
            return new Book(title, author, price);
        }

        private static void ViewBook(Book book)
        {
            Console.WriteLine("{0}, {1}, {2}", book.Title, book.Author, book.Price);
        }
    }
}
