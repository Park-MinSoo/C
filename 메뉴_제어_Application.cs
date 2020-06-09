using System;
using System.ComponentModel;

namespace 메뉴_제어하기
{
    internal class 메뉴_제어_Application
    {
        internal void init()
        {
            Console.WriteLine("사용자와 상호작용 실습");
            Console.WriteLine("아무키나 누르세요.");
            Console.ReadKey(true);
            // 아무거나 눌렀을 때 다음으로 넘어가게 끔 ReadKey 설정.
            // Readkey에 아무값이 할당 되지 않으면 누른 값이 프롬프트에 표현(에코)된다.
        }

        internal void Run()
        {
            ConsoleKey key = ConsoleKey.NoName;
            while((key = SelectMenu()) != ConsoleKey.Escape)    // 메뉴ㅠ 선택한 것이 ESC가 아니라면
            {
                switch(key)
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

                    case ConsoleKey.F5:
                        SelectMenu();
                        break;

                    default: Console.WriteLine("잘못 입력 하였습니다");
                        break;
                }
                Console.WriteLine("아무 키나 입력하세요");
                Console.ReadKey(true);
            }

            Console.WriteLine("상호작용");
        }

        private void ViewAll()
        {
            Console.WriteLine("전체 항목을 조회합니다.");
        }

        private void Search()
        {
            Console.WriteLine("검색 되었습니다.");
        }

        private void Remove()
        {
            Console.WriteLine("삭제 되었습니다.");
        }

        private void Add()
        {
            Console.WriteLine("추가 되었습니다.");
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

            // 이것은 이렇게 2줄로 표현 할 수 있다.
            /*ConsoleKeyInfo ki = Console.ReadKey(true);
            return ki.Key;*/
        }

        internal void Exit()
        {
            Console.WriteLine("사용자와 상호작용 실습 끝");
        }
    }
}