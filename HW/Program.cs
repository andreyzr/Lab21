using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW
{
    internal class Program
    {
        const int n = 4;
        const int m = 4;
        static int[,] path = new int[n, m] { { 1, 2, 5, 2 }, { 10, 5, 1, 3 }, { 6, 4, 1, 2 }, { 10, 7, 8, 10 } };
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardner2();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,2}", path[i, j]);
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (path[i, j] >= 0)
                    {
                        int dalay = path[i, j];
                        path[i, j] = -1;
                        Thread.Sleep(dalay);
                    }
                }
            }
        }
        static void Gardner2()
        {
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    if (path[i, j] >= 0)
                    {
                        int dalay = path[i, j];
                        path[i, j] = -2;
                        Thread.Sleep(dalay);
                    }
                }
            }
        }
    }
}
