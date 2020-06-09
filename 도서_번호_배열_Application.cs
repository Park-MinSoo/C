using System;

namespace 문자열
{
    internal class 도서_번호_배열_Application
    {
        int[] bnums;
        string[] titles;
        string[] authors;
        int[] prices;
        int max_books = 10; // 기본 최댓값은 10으로 설정.
        int seq = 0;

        internal void init()
        {
            Console.WriteLine("관리할 수 있는 최대 도서 수를 입력하세요");
            int.TryParse(Console.ReadLine(), out max_books);
            bnums = new int [max_books];
            Console.WriteLine("아무 키나 누르세요");
            Console.ReadKey(true);
        }

        internal void Run()
        {
            ConsoleKey key = ConsoleKey.NoName;
            while ((key = SelectMenu()) != ConsoleKey.Escape)
            {
                switch (key)
                {
                    case ConsoleKey.F1:
                        Add();
                        break;

                    case ConsoleKey.F2:
                        Remove();
                        break;

                    case ConsoleKey.F3:
                        Search();
                        break;

                    case ConsoleKey.F4:
                        ViewAll();
                        break;

                    default:
                        Console.WriteLine("잘못 입력 하였습니다");
                        break;
                }
                Console.WriteLine("아무 키나 입력하세요");
                Console.ReadKey(true);
            }

            Console.WriteLine("상호작용");
        }

        private ConsoleKey SelectMenu()
        {
            Console.Clear();    // 화면이 지워진다.
            Console.WriteLine("메뉴 [ESC:종료]");
            Console.WriteLine("F1 : 추가");
            Console.WriteLine("F2 : 삭제");
            Console.WriteLine("F3 : 검색");
            Console.WriteLine("F4 : 전체 보기");
            return Console.ReadKey(true).Key;
        }

        private void ViewAll()
        {
            for (int i =0; i < max_books; i++)
            {
                if(bnums[i] != 0)
                {
                    Console.WriteLine("책 번호는 {0}이고, 책 제목은 {1}, 저자는 {2}, 가격은 {3} 원 입니다.", bnums[i], titles[i], authors[i], prices[i]);
                }

            }
        }

        private void Search()
        {
            Console.WriteLine("몇 번째 입력한 도서를 알고 싶나요?");
            int bnum = 0;
            int.TryParse(Console.ReadLine(), out bnum);
            if (bnums[bnum -1] == 0)
            {
                Console.WriteLine("없습니다.");
                return;
            }
            Console.WriteLine("{0} 번째 도서 {1} 은(는) 지은이 {2} 이며 가격은 {3} 원 입니다.", bnums[bnum - 1], titles[bnum - 1], authors[bnum - 1], prices[bnum - 1]);
        }

        private void Remove()
        {
            Console.WriteLine("몇 번째 입력한 도서를 삭제할 것인가요?");
            int bnum = 0;
            int.TryParse(Console.ReadLine(), out bnum);
            if(bnums[bnum-1]==0)
            {
                Console.WriteLine("해당 번호 도서는 없습니다.");
            }

            bnums[bnum - 1] = 0;
            titles[bnum - 1] = null;
            authors[bnum - 1] = null;
            prices[bnum - 1] = 0;
            Console.WriteLine("정상적으로 삭제 되었습니다.");
        }

        private void Add()
        {
           if(seq == max_books)
            {
                Console.WriteLine("꽉 찼음");
                return;
            }
            seq++;
            bnums[seq - 1] = seq;   // bnums 값 할당

            Console.WriteLine("{0} 번째 입력할 도서명", seq);

            titles = new string[max_books];
            titles[seq - 1] = Console.ReadLine();

            Console.WriteLine("{0} 번째 입력할 도서 저자", seq);
            authors = new string[max_books];
            authors[seq - 1] = Console.ReadLine();

            Console.WriteLine("{0} 번째 입력할 도서 가격", seq);
            prices = new int[max_books];
            int.TryParse(Console.ReadLine(), out prices[seq - 1]);

        }

        internal void Exit()
        {
            Console.WriteLine("실습 끝");
        }
    }
}