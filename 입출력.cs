using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace 입출력_개요
{
    class 입출력
    {
        static void Main(string[] args)
        {
            int num = 23;
            string name = "홍길동";
            FileStream fs = File.Create("data.txt");
            byte[] buffer = BitConverter.GetBytes(num);
            fs.Write(buffer, 0, buffer.Length);
            buffer = Encoding.Default.GetBytes(name);
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();
        }
    }
}
