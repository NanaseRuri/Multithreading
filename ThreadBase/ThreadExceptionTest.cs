using System.Threading;
using System;
namespace Multithreading.ThreadBase
{
    public class ThreadExceptionTest
    {
        public static void ThrowExceptionWithoutCatch()
        {
            Console.WriteLine("不在方法中捕获");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            throw new Exception("方法外捕获");
        }

        public static void ThrowExceptionWithCatch()
        {
            try
            {
                Console.WriteLine("在方法中捕获");
                Thread.Sleep(TimeSpan.FromSeconds(2));
                throw new Exception("方法中捕获");
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}