using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스_개요
{
    interface IPlay
    {
        void Play();
    }

    class Musician : IPlay
    {
     public void Play()
        {
            Console.WriteLine("연주하다.");
        }
    }
    class SportsMan : IPlay
    {
        public void Play()
        {
            Console.WriteLine("운동하다.");
        }
    }
}
