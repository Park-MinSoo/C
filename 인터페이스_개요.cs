using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스_개요
{
    class 인터페이스_개요
    {
        static void Main(string[] args)
        {
            SportsMan sm = new SportsMan();
            Musician mu = new Musician();
            StartPlay(sm);
            StartPlay(mu);
        }
        private static void StartPlay(IPlay iplay)
        {
            iplay.Play();
        }
    }
}
