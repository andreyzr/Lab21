using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Пример2
{
    internal class Program
    {
        static int x = 0;
        static object locker = new object();
        public static void Print()
        {
            lock (locker)
            {
                x = 1;
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine("{0}:{1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(1000);
                }
            }

        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                ThreadStart threadStart = new ThreadStart(Print);
                Thread myThread = new Thread(threadStart);
                myThread.Name = "Поток" + i.ToString();
                myThread.Start();

            }
            Console.ReadLine();
        }
    }
}
