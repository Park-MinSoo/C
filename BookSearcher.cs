using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace 도서_검색_pre0617
{
    public static class BookSearcher
    {
        static Dictionary<string, Book> book_dic = new Dictionary<string, Book>();
        static string url = "https://dapi.kakao.com/v3/search/book?target=title";
        public static List<Book> Search(string query)
        {
            List<Book> books = new List<Book>();
            string query_str = string.Format("{0}&query={1}", url, query);
            WebRequest req = WebRequest.Create(query_str);
            req.Headers.Add("Authorization", "KakaoAK d203f36ade8c775cc83a91056f397812");
            WebResponse res = req.GetResponse();// 카카오 Open API에 질의 전송

            Stream stream = res.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string result = sr.ReadToEnd();// 전체 내용을 한번에 다 읽어옴
            JavaScriptSerializer jss = new JavaScriptSerializer();
            dynamic dobj = jss.Deserialize<dynamic>(result);    //Dynamic 형식으로 역직렬화
            dynamic docs/*object[] bobjs*/ = dobj["documents"];
            object[] d_books = docs;
            for(int i =0; i<d_books.Length;i++)
            {
                Book book = MakeBook(d_books[i]);
                if(book_dic.ContainsKey(book.ISBN)==false)
                {
                    book_dic[book.ISBN] = book;
                    books.Add(book);
                }
            }
            return books;
        }

        public static void Save()
        {
            FileStream fs = File.Create("book.csv");
            StreamWriter sw = new StreamWriter(fs);
            foreach(Book book in book_dic.Values)
            {
                sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", book.ISBN, book.Title, book.Author, book.Price, book.Desc, book.ImageUrl, book.Url, book.Publisher);
            }
            sw.Close();
            fs.Close();
        }

        public static List<Book> Load()
        {
            FileStream fs = File.OpenRead("book.csv");
            StreamReader sr = new StreamReader(fs);

            List<Book> books = new List<Book>();
            while (sr.EndOfStream == false)
            {
                string s = sr.ReadLine();
                Book book = MakeBook(s);
                books.Add(book);
                book_dic[book.ISBN] = book;
            }
            sr.Close();
            fs.Close();
            return books;
        }
        public static Book MakeBook(string s)
        {
            string[] buf = s.Split(',');
            return new Book(buf[0], buf[1], buf[2], int.Parse(buf[3]), buf[4], buf[5], buf[6], buf[7]);
        }


        private static Book MakeBook(dynamic d_book)
        {
            string title = d_book["title"];
            title = title.Replace(",", "");
            string isbn = d_book["isbn"];
            string author = d_book["authors"][0];   // 저자 부분이 배열형식으로 여려명이 되어있어서 첫번째 저자만 추출.
            author = author.Replace(",", "");
            int price = d_book["price"];
            string desc = d_book["contents"];
            desc = desc.Replace(",", "");
            string imgurl = d_book["thumbnail"];
            string url = d_book["url"];
            string publisher = d_book["publisher"];
            publisher = publisher.Replace(",", "");
            return new Book(title, isbn, author, price, desc, imgurl, url, publisher);
        }
    }
}