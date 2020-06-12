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
        public override void Draw()
        {
            Console.WriteLine("<{0}> Point({1},{2})", ID, x, y);    // <1> Point(2,3) 이런식으로 출력이 될 것이다.    
        }
    }
}