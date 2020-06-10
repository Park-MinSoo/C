using System;

namespace 클래스_활용_도서_정리
{
    internal class 클래스_활용_도서_정리_application
    {
        //int[] bnums;
        //string[] titles;
        //string[] authors;
        //int[] prices;
        Book[] books;
        int max;
        int seq;
        internal void Init()
        {
            Console.WriteLine("관리할 수 있는 최대 도서 수를 입력하세요.");
            max = int.Parse(Console.ReadLine());
            books = new Book[max];
            //bnums = new int[max];
            //titles = new string[max];
            //authors = new string[max];
            //prices = new int[max];
            Console.WriteLine("아무 키나 누르세요.");
            Console.ReadKey(true);
        }
        private void Add()
        {
            if (seq == max)
            {
                Console.WriteLine("꽉 찼음");
                return;
            }
            seq++;
            //bnums[seq - 1] = seq;
            Console.Write("{0}번째 추가할 도서 제목:", seq);
            int num = seq;
            string title = Console.ReadLine();
            //titles[seq - 1] = Console.ReadLine();
            Console.Write("저자:");
            string author = Console.ReadLine();
            //authors[seq - 1] = Console.ReadLine();
            Console.Write("가격:");
            int price = int.Parse(Console.ReadLine());
            //prices[seq-1] = int.Parse(Console.ReadLine());
            Book book = new Book (num, title, author, price);
            books[seq - 1] = book;
        }
        private void ViewAll()
        {
            for (int i = 0; i < seq; i++)
            {
                if (books[i] != null)//bnums[i] == i+1)
                {
                    ViewBook(i + 1);
                }
            }
        }

        private void ViewBook(int bnum)
        {
            Book book = books[bnum - 1];
            if (book != null)
            {
                //Console.WriteLine("{0}, {1}, {2}, {3}", bnum, titles[bnum - 1], authors[bnum - 1], prices[bnum - 1]);
                Console.WriteLine("{0}, {1}, {2}, {3}", book.Num, book.Title, book.Author, book.Price);
            }
        }

        private void Remove()
        {
            Console.Write("삭제할 도서 번호:");
            int bnum = int.Parse(Console.ReadLine());
            if (books[bnum - 1] != null)//if(bnums[bnum-1]==bnum)
            {
                //bnums[bnum - 1] = 0;
                books[bnum - 1] = null;
                Console.WriteLine("삭제 성공!!!");
            }
            else
            {
                Console.WriteLine("없습니다.");
            }
        }
        private void Search()
        {
            Console.Write("검색할 도서 번호:");
            int bnum = int.Parse(Console.ReadLine());
            if (books[bnum - 1] != null)//if (bnums[bnum - 1] == bnum)
            {
                ViewBook(bnum);
            }
            else
            {
                Console.WriteLine("없습니다.");
            }
        }

        #region Others
        private ConsoleKey SelectMenu()
        {
            Console.Clear();
            Console.WriteLine("메뉴 [ESC:종료]");
            Console.WriteLine("F1: 추가");
            Console.WriteLine("F2: 삭제");
            Console.WriteLine("F3: 검색");
            Console.WriteLine("F4: 전체 보기");
            return Console.ReadKey(true).Key;
        }
        public 클래스_활용_도서_정리_application()
        {
        }
        internal void Run()
        {
            ConsoleKey key = ConsoleKey.NoName;
            while ((key = SelectMenu()) != ConsoleKey.Escape)//메뉴 선택한 것이 ESC가 아니라면 
            {
                switch (key)//선택한 키에 따라
                {
                    case ConsoleKey.F1: Add(); break;//F1: 추가
                    case ConsoleKey.F2: Remove(); break;//F2: 삭제
                    case ConsoleKey.F3: Search(); break;//F3: 조회
                    case ConsoleKey.F4: ViewAll(); break;//F4: 전체 보기
                    default: Console.WriteLine("잘못 선택하였습니다."); break;//그 외: 잘못 선택
                }
                Console.WriteLine("아무 키나 누르세요.");
                Console.ReadKey(true);
            }

        }
        internal void Exit()
        {
            Console.WriteLine("사용자와 상호작용 실습 끝");
        }
        #endregion Others
    }
}