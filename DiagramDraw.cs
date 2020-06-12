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
        Dictionary<int, Diagram> diadic = new Dictionary<int, Diagram>();   //Dictionary 생성
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
                if (iga != null)    // 선이나, 점은 면적이 존재하지 않기에 Rectangle 타입만을 걸러내 주는 것이다.
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
                //id를 삭제해 줌으로써 dictionary에 담겨 있는 해당 diagram을 같이 삭제하는 것.
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

         // 1. dt라는 변수에 SelectDiagramType 메서드를 수행하고 사용자가 선택한 DiagramType이 dt에 담김.
         // 2. switch문을 통하여 선택된 dt에 해당하는 DiagramType(DT_LINE or DT_POINT or DT_RECTANGLE)으로
         //  MakeLine, MakePoint, MakeRectangle 등 해당 메서드의 포멧으로 생성된 return값이 diagram에 담김. 

            }
            diadic[diagram.ID] = diagram;
         // 담긴 diagram 정보를 ID값과 함께 diadic이라는 (앞단에서 정의한) dictionary에 보관을 해준다.
         // 이는 후에 remove 영역에서 id값만 가지고 쉽게 diagram을 지워주는 역할을 수행함.
         // 또 추가적으로 [F1:추가] 기능을 수행 해도 누적되어 diagram이 ID값과 함께 diadic에 저장되는 것.
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
                // ReadLine으로 사용자가 입력하여 선택한 번호에 해당하는 DiagramType을 return 시켜준다.
            }
            return DiagramType.DT_NONE; 
            // 이 구문에는 else가 빠져 있는 것이다. 즉, if문 조건에 해당 안되는 것을 골랐을 때 DiagramType은 NONE으로 return 시키라는 뜻.
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
