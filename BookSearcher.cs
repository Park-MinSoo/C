using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace 도서_검색_pre0617
{
    public static class BookSearcher
    {
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
                books.Add(book);
            }
            return books;
        }

        public static Book MakeBook(dynamic d_book)
        {
            string title = d_book["title"];
            string isbn = d_book["isbn"];
            string author = d_book["authors"][0];   // 저자 부분이 배열형식으로 여려명이 되어있어서 첫번째 저자만 추출.
            int price = d_book["price"];
            string desc = d_book["contents"];
            string imgurl = d_book["thumbnail"];
            string url = d_book["url"];
            string publisher = d_book["publisher"];
            return new Book(title, isbn, author, price, desc, imgurl, url, publisher);
        }
    }
}