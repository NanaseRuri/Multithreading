using System;
using System.Threading;
namespace Multithreading.ThreadSync
{
    public class SemaphoreSlimTest
    {
        static SemaphoreSlim _semaphore=new SemaphoreSlim(4);

        public static void Test(string name,int second){
            Console.WriteLine($"{name}");
            _semaphore.Wait();
            Console.WriteLine($"{name} get run");
            Thread.Sleep(TimeSpan.FromSeconds(second));
            Console.WriteLine($"{name} completed");
            _semaphore.Release();
        }
    }
}