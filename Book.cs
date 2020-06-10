namespace 이웃_도서_검색
{
    internal class Book
    {

        public Book(string title, string author, int price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public string Title { get; internal set; }
        public string Author { get; internal set; }
        public int Price { get; internal set; }
    }
}