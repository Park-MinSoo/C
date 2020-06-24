using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorphemeParserLib
{
    public class MorphmeParser
    {
        public class MorphemeParser
        {
            public static Dictionary<string, Morpheme> Parse(string filename, string content, out int tmcount)
            {
                Dictionary<string, Morpheme> mdic = new Dictionary<string, Morpheme>();
                tmcount = 0;
                string[] sds = filename.Split(' ');
                foreach (string s in sds)
                {
                    CheckMorpheme(mdic, s, 3);
                    tmcount++;
                }

                char[] sdatas = new char[] { '.', ',', '!', '?', ' ', '\n', '\t', '\r' };
                sds = content.Split(' ');
                foreach (string s in sds)
                {
                    if (s == "") { continue; }
                    CheckMorpheme(mdic, s, 1);
                    tmcount++;
                }
                return mdic;
            }

            private static void CheckMorpheme(Dictionary<string, Morpheme> mdic, string s, int heavy)
            {
                if (mdic.ContainsKey(s))
                {
                    Morpheme mo = mdic[s];
                    mo.RefCount += heavy;
                }
                else
                {
                    Morpheme mo = new Morpheme(s, heavy);
                    mdic[s] = mo;
                }
            }
        }
    }
}
