using System;
using System.Threading;
namespace Multithreading.ThreadSync
{
    public class MutexTest
    {
        public static void Test()
        {
            const string MutexName = "Mutex test";
            using (var m = new Mutex(false, MutexName))
            {
                if(!m.WaitOne(TimeSpan.FromSeconds(5),false)){
                    Console.WriteLine("获取不到资源");
                }
                else {
                    Console.WriteLine("运行程序");
                    Console.ReadLine();
                    m.ReleaseMutex();
                }
            }
        }
    }
}