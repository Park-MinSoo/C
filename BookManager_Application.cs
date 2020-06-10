/*                                                                                                    https://ehpub.co.kr
반도체 장비 및 제어시스템 개발자 양성과정
전체 공간 사용
 */
using System;

namespace BookManagerV02
{
    internal class Application
    {
        int[] bnums;
        string[] titles;
        string[] authors;
        int[] prices;
        int max;
        int seq;
        internal void Init()
        {
            Console.WriteLine("관리할 수 있는 최대 도서 수를 입력하세요.");
            max = int.Parse(Console.ReadLine());
            bnums = new int[max];
            titles = new string[max];
            authors = new string[max];
            prices = new int[max];
            Console.WriteLine("아무 키나 누르세요.");
            Console.ReadKey(true);
        }
        private void Add()
        {
            int seat = FindSeat();
            if(seat == max)
            {
                Console.WriteLine("꽉 찼음");
                return;
            }
            seq++;
            bnums[seat] = seq;
            Console.Write("{0}번째 추가할 도서 제목:",seq);
            titles[seat] = Console.ReadLine();
            Console.Write("저자:");
            authors[seat] = Console.ReadLine();
            Console.Write("가격:");
            prices[seat] = int.Parse(Console.ReadLine());

        }

        private int FindSeat()
        {
            int i = 0;
            for(i=0;i<max;i++)
            {
                if(bnums[i]==0)
                {
                    break;
                }
            }
            return i;
        }

        private void ViewAll()
        {
            for(int i = 0; i<seq;i++)
            {
                if(bnums[i] !=0)
                {
                    ViewBook(i);
                }
                else
                {
                    break;
                }
            }
        }

        private void ViewBook(int index)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", bnums[index], titles[index], authors[index], prices[index]);
        }

        private void Remove()
        {
            Console.Write("삭제할 도서 번호:");
            int bnum = int.Parse(Console.ReadLine());
            int seat = FindByNum(bnum);
            if (seat != -1)
            {
                ShiftLeft(seat);
                Console.WriteLine("삭제 성공");
            }
            else
            {
                Console.WriteLine("없습니다.");
            }
        }

        private void ShiftLeft(int seat)
        {
            for(; (seat+1)<max;seat++)
            {
                bnums[seat]= bnums[seat + 1];
                titles[seat] = titles[seat + 1];
                authors[seat] = authors[seat + 1];
                prices[seat] = prices[seat + 1];

            }
        }

        private int FindByNum(int bnum)
        {
            int i = 0;
            for(i=0;i<max;i++)
            {
                if(bnums[i]==0)
                {
                    return -1;
                }
                if(bnums[i]>bnum)
                {
                    return -1;
                }
                if(bnums[i]==bnum)
                {
                    return i;
                }
            }
            return -1;
        }

        private void Search()
        {
            Console.Write("검색할 도서 번호:");
            int bnum = int.Parse(Console.ReadLine());
            int seat = FindByNum(bnum);
            if (seat != -1)
            {
                ViewBook(seat);
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
        public Application()
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