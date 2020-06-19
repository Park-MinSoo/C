using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class 형태소_분석기Form : Form
    {
        public 형태소_분석기Form()
        {
            InitializeComponent();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            MessageBox.Show("원본 파일이 있는 폴더를 선택하세요.");
            fbd.ShowDialog();
            tbox_org.Text = fbd.SelectedPath;

            MessageBox.Show("분석한 파일을 옮길 폴더를 선택하세요.");
            fbd.ShowDialog();
            tbox_par.Text = fbd.SelectedPath;

            MessageBox.Show("분석 내용의 Base 폴더를 선택하세요.");
            fbd.ShowDialog();
            tbox_dat.Text = fbd.SelectedPath;

            btn_mo_parse.Enabled = true;
        }

        private void btn_mo_parse_Click(object sender, EventArgs e)
        {
            OriginDirPeek();
            while(lbox_org.Items.Count>0)
            {
                Parsing(lbox_org.Items[0].ToString());
                lbox_org.Items.RemoveAt(0);
            }
        }
        string dm_file = "dmcnt.txt";   // 파일명 - 형태소 개수
        string inv_file = "index.txt";  // 역파일 (처음 발견한 형태소 이름)
        string inv_dir = "inv"; //역파일 폴더명

        private void Parsing(string filename)
        {
            FileStream fs = File.OpenRead(filename);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            string dname;
            string fname = SplitDirFname(filename, out dname);
            string mfname = string.Format(@"{0}\{1}", tbox_par.Text, fname);
            File.Move(filename, mfname);
            lbox_par.Items.Add(mfname);
            int tot_mcnt = 0;
            Dictionary<string, Morpheme> mor_dic = MorphemeParser.Parse(filename, s,out tot_mcnt);

            SaveDocMoCnt(filename, tot_mcnt);
            MakeInvFile(filename, mor_dic);
        }

        private void MakeInvFile(string filename, Dictionary<string, Morpheme> mor_dic)
        {
            string ind_filename = string.Format(@"{0}\{1}", tbox_dat.Text, inv_file);
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

            foreach(Morpheme mo in mor_dic.Values)
            {
                if(mors.Contains(mo.Name)==false)
                {
                    mors.Add(mo.Name);
                }
                int index = mors.IndexOf(mo.Name);
                MakeInvFileData(mo,index, filename);
            }

            FileStream fs3 = File.OpenRead(ind_filename);
            StreamWriter sw = new StreamWriter(fs3);

            foreach(string name in mors)
            {
                sw.WriteLine(name);
            }
            sw.Close();
            fs3.Close();

        }

        private void MakeInvFileData(Morpheme mo, int index, string filename)
        {
            string inv_filename = string.Format(@"{0}\{1}\{2}.txt", tbox_dat.Text, inv_dir, index);
            if(File.Exists(inv_filename)==false)
            {
                FileStream fs = File.Create(inv_filename);
                fs.Close();
            }
            FileStream fs2 = File.OpenRead(inv_filename);
            StreamWriter sw = new StreamWriter(fs2);
            sw.WriteLine("{0},{1}", filename, index);

            sw.Close();
            fs2.Close();
        }

        private void SaveDocMoCnt(string filename, int tot_mcnt)
        {
            string dm_filename = string.Format(@"{0}\{1}", tbox_dat.Text, dm_file);
            if(File.Exists(dm_filename)==false)
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

        private string SplitDirFname(string filename, out string dname)
        {
            int index = filename.LastIndexOf(@"\");
            if(index == -1)
            {
                dname = "";
                return filename;
            }
            dname = filename.Substring(0, index+1);
            return filename.Substring(index + 1);
        }

        private void OriginDirPeek()
        {
            DirectoryInfo di = new DirectoryInfo(tbox_org.Text);
            FileInfo[] fis = di.GetFiles();
            foreach (FileInfo fi in fis)
            {
                lbox_org.Items.Add(fi.FullName);
            }
        }
    }
}
