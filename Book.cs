using System.Globalization;

namespace 클래스_활용_도서_정리
{
    internal class Book
    {
        public Book(int num, string title, string author, int price)
        {
            Num = num;
            Title = title;
            Author = author;
            Price = price;
        }
        public int Num { get; internal set; }
        public string Title { get; internal set; }
        public string Author { get; internal set; }
        public int Price { get; internal set; }

    }
}