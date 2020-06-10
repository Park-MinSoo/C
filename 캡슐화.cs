using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace 캡슐화_lab
{
    class MyRectangle
    {
        /*int left;   //가져오기, 설정하기
        int right;  //가져오기, 설정하기
        int top;    //가져오기, 설정하기
        int bottom; //가져오기, 설정하기
        int width;  //가져오기
        int height; //가져오기
        int area;   //가져오기*/

        internal int Left { get; set; }
        internal int Right { get; set; }
        internal int Top { get; set; }
        internal int Bottom { get; set; }

        internal int Width { get {
                if (Right > Left) { return (Right - Left); }
                else { return (Left - Right); } 
            } }
        internal int Height { get {
                if (Top > Bottom) { return (Top - Bottom); }
                else { return (Bottom - Top); }
            }
        }
        internal int Area { get { return (Width * Height); } }
    }


    class 캡슐화
    {
        static void Main(string[] args)
        {
            MyRectangle a = new MyRectangle();
            a.Left = 100;
            a.Right = 50;
            a.Top = 30;
            a.Bottom = 70;
            Console.WriteLine("도형 a 의 길이 : {0}", a.Width);
            Console.WriteLine("도형 a 의 높이 : {0}", a.Height);
            Console.WriteLine("도형 a 의 넓이 : {0}", a.Area);
        }
    }
}
