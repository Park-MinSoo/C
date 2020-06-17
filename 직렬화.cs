using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace 직렬화
{
    class 직렬화
    {
        static void Main(string[] args)
        {
            DataManager dm = new DataManager();
            dm.Add("홍길동",20);
            dm.Add("강감찬",24);
            dm.Add("이순신",46);
            FileStream fs = File.Create("data.txt");

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, dm);
            fs.Close();

            FileStream fs2 = File.OpenRead("data.txt");
            BinaryFormatter bf2 = new BinaryFormatter();
            DataManager dm2 = bf2.Deserialize(fs2) as DataManager;
            foreach(Data data in dm2)
            {
                Console.WriteLine(data);
            }
        }
    }
}
