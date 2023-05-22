using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PW
{
    internal class Program
    {
        const int n = 10;
        static int[] path = new int[n] { 1, 2, 0, 50, 5, 0, 1, 2, 6, 10 };
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread=new Thread(threadStart);
            thread.Start();

            Gardner2();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{path[i]}");
            }
            Console.ReadKey();
        }
        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                if (path[i]>=0)
                {
                    int dalay = path[i];
                    path[i] = -1;
                    Thread.Sleep(dalay);
                }
            }
        }
        static void Gardner2()
        {
            for (int i = n-1; i >= 0; i--)
            {
                if (path[i] >= 0)
                {
                    int dalay = path[i];
                    path[i] = -2;
                    Thread.Sleep(dalay);
                }
            }
        }
    }
}

