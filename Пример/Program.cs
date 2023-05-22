using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Пример
{
    internal class Program
    {
        static void Print1(object name)
        {
            while (true)
            {
                Console.WriteLine((string)name);
            }
        }
        static void Print2(object name)
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 20) + (string)name);
            }
        }
        static void Main(string[] args)
        {
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Print2);
            Thread thread = new Thread(threadStart);
            thread.Start("Secondary");
            Print1("Primary");

        }
    }
}
