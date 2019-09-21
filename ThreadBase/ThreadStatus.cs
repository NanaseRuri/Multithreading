using System;
using System.Threading;
namespace Multithreading.ThreadBase
{
    class ThreadStatus
    {
        public static void Test()
        {
            Thread t = new Thread(QuickStart.PrintNumber);
            t.Start();
            Console.WriteLine(t.ThreadState);
            t.Join();
            Console.WriteLine(t.ThreadState);
            // .NET Core Unsupport
            // t.Abort();
            // Console.WriteLine(t.ThreadState);
        }
    }
}