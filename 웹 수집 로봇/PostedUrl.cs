using System;
using System.IO;

namespace 웹_수집_로봇
{
    public class PostedUrl
    {

        const string origin_dir = @"D:\EData\Origin";
        const string parsed_dir = @"D:\EData\Parsed";
        const string data_dir = @"D:\EData";
        const string dm_file = "dmcnt.txt";
        const string inv_file = "index.txt";
        const string inv_dir = "inv";

        public void Save()
        {
            string fname = string.Format(@"{0}\{1}", origin_dir, Title);
            if(File.Exists(fname))
            {
                DateTime dt = DateTime.Now;
                fname = string.Format(@"{0}{1}{2}{3}{4}{5}{6}{7}.txt",
                    origin_dir,Title,dt.Year,dt.Month,dt.Day,dt.Hour,dt.Minute,dt.Second);
            }
            FileStream fs = File.Create(fname);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(Url);
            sw.Write(Content);
            sw.Close();
            fs.Close();
        }

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
        public string Title
        {
            get;
            set;
        }
        public string Content
        {
            get;
            set;
        }

        public PostedUrl(string url, int depth, string title, string content)
        {
            Url = url;
            Depth = depth;
            Title = title;
            Content = content;
        }
        public override string ToString()
        {
            return Url;
        }
    }
}