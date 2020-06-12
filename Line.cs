using System;

namespace 도형_실습
{
    public class Line : Diagram
    {
        Point p1, p2;
        public Line(int x1, int y1, int x2, int y2)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
        }

        public override void Draw() // Diagram에서 추상적이였던 Draw 메서드를 Line 클래스에 맞게 오버라이딩 하여 정의해준다.
        {
            Console.WriteLine("<{0}> Line", ID);
            Console.Write("\t");
            p1.Draw();
            Console.WriteLine("<{0}> Line", ID);
            Console.Write("\t");
            p2.Draw();
        }
    }
}