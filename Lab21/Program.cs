using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab21
{
    internal class Program
    {
        static void Print1()
        {
            while (true)
            {
                Console.WriteLine("Primary");
            }
        }
        static void Print2()
        {
            while (true)
            {
                Console.WriteLine(new string(' ',20)+"Secondary") ;
            }
        }
        static void Main(string[] args)
        {
            ThreadStart threadStar=new ThreadStart(Print2);
            Thread thread=new Thread(threadStar);
            thread.Start();
            Print1 ();
        }
    }
}
