using System;

namespace 도형_실습
{
    public class Rectangle : Diagram,IGetArea // Diagram 과 IGetArea의 순서를 바꿔 쓰면 안된다.
    {
         int left;
         int top;
         int right;
         int bottom;

        public Rectangle(int left, int top, int right, int bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }
        public override void Draw()
        {
            Console.WriteLine("<{0}> Rectangle({1},{2},{3},{4})",ID,left,top,right,bottom);
        }

        public int GetArea()
        {
            int width = right - left;
            int height = bottom - top;
            return Math.Abs(width * height);
        }
    }
}