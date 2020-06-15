using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 스큐
{
    class 스텍과_큐
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(4);
            stack.Push(5);
            stack.Push(2);
            Console.WriteLine(stack.Pop()); //2
            stack.Push(3);
            Console.WriteLine(stack.Pop()); //3
            while(stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("---------------------------");
            
            Queue queue = new Queue();
            queue.Enqueue(4);//put이라고도 부름
            queue.Enqueue(5);
            queue.Enqueue(2);
            Console.WriteLine(queue.Dequeue());//get 이라고도 부름
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue());
            while(queue.Count>0)
            {
                Console.WriteLine(queue.Dequeue());
            }

        }
    }
}
