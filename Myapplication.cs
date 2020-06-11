using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnitLib;

namespace 유닛응용
{
    class MyApplication
    {

        internal static MyApplication Singleton
        {
            get;
            private set;
        }
        static MyApplication()
        {
            Singleton = new MyApplication();
        }
        MyApplication()
        {

        }



        List<Unit> units = new List<Unit>();

        const int ucnt = 10;
        internal void Init()
        {
            int i = 0;
            Unit unit = null;
            for(i=0;i<ucnt;i++)
            {
                unit = MakeUnit(i + 1);
                units.Add(unit);
            }
            Console.WriteLine("유닛 키우기");
            Console.WriteLine("암 키나 누르면 시작");
            //Console.Write("이름: ");
            //string name = Console.ReadLine();   //일단 public으로 하자고 임의로 판단 but 문제 있으면 바로 internal로 바꾸자
            Console.WriteLine("암키나 누르면 시작합니다.");
            Console.ReadKey(true);
        }

        private Unit MakeUnit(int nth)
        {
            Unit oneunit = null;
            Console.WriteLine("{0}번째 생성할 유닛이름", nth);
            string name = Console.ReadLine();
            oneunit = new Unit(name);

            return oneunit;

        }

        internal void Run()
        {

            

            ConsoleKey key = ConsoleKey.NoName;
            while ((key = SelectMenu()) != ConsoleKey.Escape)
            {
                switch(key)
                {
                    case ConsoleKey.F1: Study();    break;
                    case ConsoleKey.F2: Dance(); break;
                    case ConsoleKey.F3: Sing(); break;
                    case ConsoleKey.F4: ViewAll(); break;
                    default: Console.WriteLine("잘못 선택했어요"); break;
                }
                Console.WriteLine("아무키나 누르세요");
                Console.ReadKey(true);
            }
        }

        private void ViewAll()
        {
            foreach (Unit unit in units)
            {
                Console.WriteLine("====== {0} ====== ", unit);
                Console.WriteLine("이름: {0} IQ: {1} CP: {2}", unit, unit.IQ, unit.CP);
            }
            
        }

        private void Sing()
        {
            foreach (Unit unit in units)
            {
                Console.WriteLine("====== {0} ====== ", unit);
                unit.Sing(3);
                Console.WriteLine("IQ: {0}  CP: {1}", unit.IQ, unit.CP);
            }
            
        }

        private void Dance()
        {
            foreach (Unit unit in units)
            {
                Console.WriteLine("====== {0} ====== ", unit);

                unit.Dance(3);
                Console.WriteLine("CP: {0}", unit.CP);
            }
        }

        private void Study()
        {
            foreach (Unit unit in units)
            {
                Console.WriteLine("====== {0} ====== ", unit);
                unit.Study(3);
                Console.WriteLine("IQ: {0}", unit.IQ);
            }
        }

        private ConsoleKey SelectMenu()
        {
            Console.Clear();
            Console.WriteLine("F1: 공부, F2: 춤 ,F3: 노래, F4, 전체보기");
            Console.WriteLine("{0}: Study", ConsoleKey.F1);
            Console.WriteLine("{0}: Dance", ConsoleKey.F2);
            Console.WriteLine("{0}: Sing", ConsoleKey.F3);
            Console.WriteLine("{0}: Viewall", ConsoleKey.F4);

            return Console.ReadKey(true).Key;

        }

        internal void Exit()
        {
            Console.WriteLine("암 키나 누르면 꺼짐");
            Console.ReadKey(true);
        }
    }
}
