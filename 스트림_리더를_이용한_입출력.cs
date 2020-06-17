using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 스트림_리더를_이용한_입출력
{
    class 스트림_리더를_이용한_입출력
    {
        static void Main(string[] args)
        {
            FileStream fs = File.Create("data.txt");
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("이름:{0} 나이:{1}","홍길동", 27);
            sw.Close();
            fs.Close();

            FileStream fs2 = File.OpenRead("data.txt");
            StreamReader sr = new StreamReader(fs2);
            string input = sr.ReadLine();
            sr.Close();
            fs2.Close();
            Console.WriteLine(input);

            FileStream fs3 = File.Create("data2.txt");
            BinaryWriter bw = new BinaryWriter(fs3);
            int num = 27;
            string name = "홍길동";
            bw.Write(num);
            bw.Write(name);
            bw.Close();
            fs3.Close();

            FileStream fs4 = File.OpenRead("data2.txt");
            BinaryReader br = new BinaryReader(fs4);
            int num2;
            string name2;
            num2 = br.ReadInt32();
            name2 = br.ReadString();
            bw.Close();
            fs4.Close();

            FileStream fs5 = File.Create("data3.txt");
            byte[] nb = BitConverter.GetBytes(num);
            fs5.Write(nb, 0, nb.Length);
            byte[] nab = Encoding.Default.GetBytes(name);
            fs5.Write(nab, 0, nab.Length);
            fs5.Close();

        }
    }
}
