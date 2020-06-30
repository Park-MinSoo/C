using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 웹_수집_로봇
{
    class Candidate
    {
        public string Url
        {
            get;
            set;
        }

        public int Depth
        {
            get;
            set;
        }
        public Candidate(string url, int depth)
        {
            Url = url;
            Depth = depth;
        }
        public override string ToString()
        {
            return Url;
        }
    }
}
