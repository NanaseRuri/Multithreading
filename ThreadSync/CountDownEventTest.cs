using System;
using System.Threading;

using static System.Console;
using static System.Threading.Thread;
namespace Multithreading.ThreadSync
{
    public class CountDownEventTest
    {
        static CountdownEvent _countdownEvent=new CountdownEvent(3);

        static void Work(int second,string message){
            Sleep(TimeSpan.FromSeconds(second));
            WriteLine(message);
            _countdownEvent.Signal();
        }

        public static void Test(){
            Thread t1=new Thread(()=>Work(5,"5 second"));
            Thread t2=new Thread(()=>Work(7,"7 second"));
            Thread t3=new Thread(()=>Work(4,"4 second"));

            t1.Start();
            t2.Start();
            t3.Start();

            _countdownEvent.Wait();
            Console.WriteLine("任务完成");
            // _countdownEvent.Dispose();
        }
    }
}