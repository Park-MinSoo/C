using System;

namespace 도형_실습
{
    internal class Point : Diagram
    {
        int x;
        int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override void Draw() // Diagram에서 추상적이였던 Draw 메서드를 Point 클래스에 맞게 오버라이딩 하여 정의해준다.
        {
            Console.WriteLine("<{0}> Point({1},{2})", ID, x, y);    // <1> Point(2,3) 이런식으로 출력이 될 것이다.    
        }
    }
}