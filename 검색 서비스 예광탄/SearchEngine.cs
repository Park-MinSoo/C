using System;
using System.Collections.Generic;
using System.IO;
using MorphemeParserLib;
using static MorphemeParserLib.MorphmeParser;

namespace 검색_서비스_예광탄
{
    public class SearchEngine
    {
        public static List<RankedUrl> Search(string query)
        {
            const string origin_dir = @"D:\EData\Origin";   //tbox_org.Text
            const string parsed_dir = @"D:\EData\Parsed";   //tbox_par.Text
            const string data_dir = @"D:\EData";   //tbox_dat.Text
            const string dm_file = "dmcnt.txt";//파일명 - 형태소 개수
            const string inv_file = "index.txt";//처음 발견한 형태소 이름
            const string inv_dir = "inv";//역파일 폴더명

            int cnt = 0;
            List<RankedUrl> rurls = new List<RankedUrl>();
            Dictionary<string,Morpheme> mdic = MorphemeParser.Parse("", query, out cnt);
            foreach(string word in mdic.Keys)
            {
                if(mors.Contains(word))
                {
                    rurls.Add(MakeRankedUrl(word));
                }
            }
            return rurls;
        }

        private static RankedUrl MakeRankedUrl(string word)
        {
            throw new NotImplementedException();
        }

        static List<string> mors = null;
        static SearchEngine()
        {
            string index_fname = string.Format(@"{0}\{1}", data_dir, inv_file);

            FileStream fs = File.OpenRead(index_fname);
            StreamReader sr = new StreamReader(fs);
            mors = new List<string>();
            while (sr.EndOfStream ==false)
            {
                mors.Add(sr.ReadLine());
            }
            sr.Close();
            fs.Close();
        }
    }
}