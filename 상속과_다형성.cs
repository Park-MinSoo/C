using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속과_다형성
{
    class 상속과_다형성
    {
        static void Main(string[] args)
        {
/*            Pianist pianist = new Pianist(3);
            pianist.Play();
            // pianist.MNum = 3; // 사용을 못한다.
     
            Drummer drummer = new Drummer(2);
            drummer.Play();
            Musician mu = null;
            mu = pianist;
            mu.Play();
            mu = drummer;
            mu.Play();
*/
            Musician[] band = new Musician[2];
            band[0] = new Pianist(1);
            band[1] = new Drummer(2);
            foreach(Musician mu2 in band)
            {
                Pianist pianist = mu2 as Pianist;   // as는 이게 맞는지에 대한 참조 확인 연산자이다.
                if (pianist != null)
                {
                    pianist.Tuning();
                }
                mu2.Play();
                if(mu2 is Drummer)  // is는 모든 형식이다.
                {
                    Drummer drummer = (Drummer)mu2;
                    drummer.Polling();
                }
            }



        }
    }
}
