using System.Runtime.CompilerServices;
using System.Threading;
using System;
namespace Multithreading.ThreadBase
{
    public class QuickStart
    {
        public static void PrintNumber()
        {
            Console.WriteLine("member");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(2);
                Console.WriteLine(i);
            }
        }
    }
}