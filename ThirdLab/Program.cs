using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyStack<string> stack1 = new MyStack<string>(8);
                stack1.Push("Koshka");
                stack1.Push("Sobaka");
                stack1.Push("Kozel");
                stack1.Push("Baran");

                var head = stack1.Pop();
                Console.WriteLine(head);

                head = stack1.Peek();
                Console.WriteLine(head);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Queue<string> q = new Queue<string>(5);
            q.Enqueue("Apple");
            q.Enqueue("Banana");
            q.Enqueue("Orange");
            q.Enqueue("Watermelon");
            Console.WriteLine("Куплено: " + q.Dequeue());
            Console.WriteLine("Куплено: " + q.Dequeue());

            foreach (string c in q)
            {
                Console.WriteLine("Осталось купить: " + c);
            }
            Console.WriteLine("Всего осталось: " + q.Count.ToString());
            Console.Read();
        }
    }
}
