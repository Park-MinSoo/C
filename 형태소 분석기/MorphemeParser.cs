using System;
using System.Collections.Generic;
using System.Drawing;

namespace App1
{
    internal class MorphemeParser
    {
        internal static System.Collections.Generic.Dictionary<string, Morpheme> Parse(string filename, string content, out int tmcount)
        {
            Dictionary<string, Morpheme> mdic = new Dictionary<string, Morpheme>();
            tmcount = 0;
            char[] sdatas = new char[] { '.', ',', '!', '?', '\n', '\t', '\r' };
            string[] sds = filename.Split(sdatas);
            foreach(string s in sds)
            {
                CheckMorpheme(mdic, s,3);
                tmcount++;
            }
           
            sds = content.Split(' ');
            foreach (string s in sds)
            {
                CheckMorpheme(mdic, s,1);
                tmcount++;
            }
            return mdic;
        }

        private static void CheckMorpheme(Dictionary<string, Morpheme> mdic, string s,int heavy)
        {
            if(mdic.ContainsKey(s))
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