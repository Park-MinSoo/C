using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열
{
    class 배열
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            for(int i =0;i<arr.Length;i++)
            {
                arr[i] = rand.Next(100);
            }
            Array.Sort(arr);

            foreach(int elem in arr)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
