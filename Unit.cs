using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLib
{
     /// <summary>
     /// 유닛 클리스
     /// </summary>
    public class Unit
    {
        #region 멤버필드 

        int iq; //아이큐(0~200)
        int cp; //매력(0~100)
        readonly int no;//set block x(읽기 정용) //번호 - 읽기 전용, 순차 부여
        //string name;//자동화 속성 이용
        static int lastnum; //      가장 최근에 부여한 번호 - 정적멤버

        const int max_iq = 200;
        const int max_cp = 100;
      
        //      이름

        

        #endregion 멤버필드

        #region 멤버속성
        public int IQ
        {
            get
            {
                return iq;
            }

            private set
            {
                if (iq > max_iq)
                {
                    value = 200;
                }
                if (iq < max_iq)
                {
                    value = 0;
                }
                iq = value;

            }
        }
        public int CP
        {
            get
            {
                return cp;
            }

            private set
            {
                if (cp > max_cp)
                {
                    value = 100;
                }
                if (cp < max_cp)
                {
                    value = 0;
                }
                cp = value;

            }
        }

        public int Num
        {
            get
            {
                return no;
            }
        }

        internal string Name  // 문제 있으면 손 봐주자
        {
            get;
            
            private set;
        }

        public static int Lastnum
        {
            get
            {
                return lastnum;
            }
        }
        #endregion 멤버속성


        #region 멤버메서드
        public Unit(string name)
        {
            Name = name;
            lastnum++;
            no = lastnum;
            IQ = 0; // 확인해보기
            CP = 0; // 확인해보기

        }

        public void Study(int cnt)
        {
            Console.WriteLine("{0}만큼 공부했다.",cnt);
            iq += cnt;
            //IQ += cnt; //iq 안될때 이걸로
        }

        public void Dance(int cnt)
        {
            Console.WriteLine("{0}만큼 춤췄다.", cnt);
            cp += cnt;
            //CP += cnt; //cp 안될때 이걸로
        }

        public void Sing(int cnt)
        {
            Console.WriteLine("{0}만큼 노래했다.",cnt);
            cp += cnt/2;
            iq += cnt/2;
            //CP += cnt; //cp 안될때 이걸로
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}",no, Name);
        }

        #endregion 멤버메서드

    }
}
