namespace 도형_실습
{
    internal class Rectangle : Diagram
    {
        private int left;
        private int top;
        private int right;
        private int bottom;

        public Rectangle(int left, int top, int right, int bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }
    }
}