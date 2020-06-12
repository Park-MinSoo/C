using System;

namespace 도형_실습
{
    public class Rectangle : Diagram,IGetArea // Diagram 과 IGetArea의 순서를 바꿔 쓰면 안된다. Diagram을 상속 받는것이 우선.
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
        public override void Draw() // Diagram에서 추상적이였던 Draw 메서드를 Rectangle 클래스에 맞게 오버라이딩 하여 정의해준다.
        {
            Console.WriteLine("<{0}> Rectangle({1},{2},{3},{4})",ID,left,top,right,bottom);
        }

        public int GetArea()
        {
            int width = right - left;
            int height = bottom - top;
            return Math.Abs(width * height);
            // width나 height는 right 나 left 그리고 bottom 이나 top의 값에 따라서 음수의 값이 나올 수 있다.
            // 따라서 Math.Abs()를 사용하여 절댓값 처리(넓이는 무조건 양수 이므로)를 수행한다.
        }
    }
}