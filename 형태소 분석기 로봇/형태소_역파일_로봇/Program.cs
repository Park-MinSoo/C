using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MorphemeParserLib;
using static MorphemeParserLib.MorphmeParser;

namespace 형태소_역파일_로봇
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(TMParsing);
            timer.Change(0, 100000);    //100초
            Console.ReadKey();  // 아무키나 누르면 멈추게.
        }
        static void TMParsing(object state)
        {
            OriginDirPeek();
            Console.Write(".{0}",files.Count);
            while (files.Count >0)
            {
                Parsing(files[0]);
                files.RemoveAt(0);
            }
        }

        const string origin_dir = @"D:\EData\Origin";   //tbox_org.Text
        const string parsed_dir = @"D:\EData\Parsed";   //tbox_par.Text
        const string data_dir =  @"D:\EData";   //tbox_dat.Text
        const string dm_file = "dmcnt.txt";//파일명 - 형태소 개수
        const string inv_file = "index.txt";//처음 발견한 형태소 이름
        const string inv_dir = "inv";//역파일 폴더명


        static void Parsing(string filename)
        {
            FileStream fs = File.OpenRead(filename);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            string dname;
            string fname = SplitDirFname(filename, out dname);
            string mfname = string.Format(@"{0}\{1}", parsed_dir, fname);
            File.Move(filename, mfname);

            int tot_mcnt = 0;
            Dictionary<string, Morpheme> mor_dic = MorphemeParser.Parse(filename, s, out tot_mcnt);

            SaveDocMoCnt(filename, tot_mcnt);
            MakeInvFile(filename, mor_dic);
        }

        private static void MakeInvFile(string filename, Dictionary<string, Morpheme> mor_dic)
        {
            string ind_filename = string.Format(@"{0}\{1}", data_dir, inv_file);
            
            if (File.Exists(ind_filename) == false)
            {
                FileStream fs = File.Create(ind_filename);
                fs.Close();
            }

            FileStream fs2 = File.OpenRead(ind_filename);
            StreamReader sr = new StreamReader(fs2);
            List<string> mors = new List<string>();

            while (sr.EndOfStream == false)
            {
                mors.Add(sr.ReadLine());
            }

            sr.Close();
            fs2.Close();



            foreach (Morpheme mo in mor_dic.Values)
            {
                if (mors.Contains(mo.Name) == false)
                {
                    mors.Add(mo.Name);
                }
                int index = mors.IndexOf(mo.Name);
                MakeInvFileData(mo, index, filename);




            }
            FileStream fs3 = File.Create(ind_filename);
            StreamWriter sw = new StreamWriter(fs3);

            foreach (string name in mors)
            {
                sw.WriteLine(name);
            }
            sw.Close();
            fs3.Close();
        }

        private static void MakeInvFileData(Morpheme mo, int index, string filename)
        {
            string inv_filename = string.Format(@"{0}\{1}\{2}.txt", data_dir, inv_dir, index);
/*
            if (File.Exists(inv_filename) == false)
            {
                FileStream fs = File.Create(inv_filename);
                fs.Close();
            }
*/
            FileStream fs2 = File.Open(inv_filename, FileMode.Append);

            StreamWriter sw = new StreamWriter(fs2);
            sw.WriteLine("{0},{1}", filename, mo.RefCount);
            sw.Close();
            fs2.Close();
        }

        private static void SaveDocMoCnt(string filename, int tot_mcnt)
        {
            string dm_filename = string.Format(@"{0}\{1}", data_dir, dm_file);
            if (File.Exists(dm_filename) == false)
            {
                FileStream fs = File.Create(dm_filename);
                fs.Close();
            }
            FileStream fs2 = File.Open(dm_filename, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs2);
            sw.WriteLine("{0},{1}", filename, tot_mcnt);
            sw.Close();
            fs2.Close();
        }

        private static string SplitDirFname(string filename, out string dname)
        {
            int index = filename.LastIndexOf(@"\");
            if (index == -1)
            {
                dname = "";
                return filename;
            }
            dname = filename.Substring(0, index + 1);
            return filename.Substring(index + 1);
        }

        static List<string> files = new List<string>();
        private static void OriginDirPeek()
        {
            DirectoryInfo di = new DirectoryInfo(origin_dir);
            FileInfo[] fis = di.GetFiles();
            foreach (FileInfo fi in fis)
            {
                files.Add(fi.FullName);
            }
        }



    }
}
