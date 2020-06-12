using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 도형_실습
{
    public enum DiagramType
    {
        DT_NONE,DT_POINT,DT_LINE,DT_RECTANGLE,DT_MAX=DT_RECTANGLE
    }
    public class DiagramDraw
    {
        Dictionary<int, Diagram> diadic = new Dictionary<int, Diagram>();
        private Diagram diagram;

        public static DiagramDraw Sigleton { get; private set; }

        static DiagramDraw()
        {
            Sigleton = new DiagramDraw();
        }
        DiagramDraw()
        {

        }

        public void Run()
        {
            ConsoleKey key;
            while((key = SelectMenu())!=ConsoleKey.Escape)
            {
                switch(key)
                {
                    case ConsoleKey.F1: AddDiagram();break;
                    case ConsoleKey.F2: RemoveDiagram(); break;
                    case ConsoleKey.F3: FindDiagram(); break;
                    case ConsoleKey.F4: ViewAll(); break;
                    default: Console.WriteLine("잘못 선택하였습니다."); break;
                }
                Console.WriteLine("아무 키나 누르세요.");
                Console.ReadKey(true);
            }
        }

        private void ViewAll()
        {
            foreach(Diagram diagram in diadic.Values)
            {
                ViewDiagram(diagram);
            }
        }

        private void ViewDiagram(Diagram diagram)
        {
            diagram.Draw();
                IGetArea iga = diagram as IGetArea;
                if (iga != null)
                { 
                    int area = iga.GetArea();
                    Console.WriteLine("면적:{0}", area);
                }
        }

        private void FindDiagram()
        {
            int id = 0;
            Console.Write("찾을 도형 ID:");
            int.TryParse(Console.ReadLine(), out id);
            if (diadic.ContainsKey(id))
            {
                Diagram diagram = diadic[id];
                ViewDiagram(diagram);
            }
            else
            {
                Console.WriteLine("존재하지 않는 도형입니다.");
            }

        }

        private void RemoveDiagram()
        {
            int id = 0;
            Console.Write("삭제할 도형 ID:");
            int.TryParse(Console.ReadLine(), out id);
            if(diadic.ContainsKey(id))
            {
                diadic.Remove(id);
                //Diagram diagram = diadic[id];
            }
            else
            {
                Console.WriteLine("존재하지 않는 도형입니다.");
            }
        }

        private void AddDiagram()
    {
        Console.WriteLine("도형 추가 기능 ===");
            DiagramType dt = SelectDiagramType();
            switch(dt)
                {
                case DiagramType.DT_LINE: diagram = MakeLine(); break;
                case DiagramType.DT_POINT: diagram = MakePoint(); break;
                case DiagramType.DT_RECTANGLE: diagram = MakeRectangle(); break;
                default: Console.WriteLine("잘못 선택하였습니다."); return;
            }
            diadic[diagram.ID] = diagram;
    }

        private Diagram MakeRectangle()
        {
            int left = 0, top = 0, right = 0, bottom = 0;

            Console.Write("좌측 상단 X:");
            int.TryParse(Console.ReadLine(), out left);

            Console.Write("좌측 상단 Y:");
            int.TryParse(Console.ReadLine(), out top);

            Console.Write("우측 하단 X:");
            int.TryParse(Console.ReadLine(), out right);

            Console.Write("우측 하단 Y:");
            int.TryParse(Console.ReadLine(), out bottom);

            return new Rectangle(left,top,right,bottom);
        }

        private Diagram MakePoint()
        {
            int x = 0, y = 0;

            Console.Write("X:");
            int.TryParse(Console.ReadLine(), out x);

            Console.Write("Y:");
            int.TryParse(Console.ReadLine(), out y);

            return new Point(x, y);
        }

        private Diagram MakeLine()
        {
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            Console.Write("첫 번째 점의 X:");
            int.TryParse(Console.ReadLine(), out x1);

            Console.Write("첫 번째 점의 Y:");
            int.TryParse(Console.ReadLine(), out y1);

            Console.Write("두 번째 점의 X:");
            int.TryParse(Console.ReadLine(), out x2);

            Console.Write("두 번째 점의 Y:");
            int.TryParse(Console.ReadLine(), out y2);

            return new Line(x1, y1, x2, y2);
        }


        private DiagramType SelectDiagramType()
        {
            Console.WriteLine("도형 타입을 선택하세요.");
            int i = 0;
            for(i=1;i<=(int)DiagramType.DT_MAX;i++)  // 정수값이 범위를 벗어날 수 있기 때문
            {
                Console.WriteLine("{0}:{1}", i, (DiagramType)i);
            }
            int dt = 0;
            int.TryParse(Console.ReadLine(), out dt);   //사용자로 부터 정수를 입력받음.
            if((dt>0)&&(dt<=(int)DiagramType.DT_MAX))
            {
                return (DiagramType)dt;
            }
            return DiagramType.DT_NONE;
        }



        private ConsoleKey SelectMenu()
    {
        Console.Clear();
        Console.WriteLine("도형 그리자~");
        Console.WriteLine("F1:추가 F2:삭제 F3:검색 F4:목록 ESC:종료");
        return Console.ReadKey(true).Key;
    }


     
    }
}
