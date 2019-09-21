using System.Threading;
using System;
using Multithreading.ThreadSync;


using static System.Console;
using static System.Threading.Thread;
namespace Multithreading
{
    public class ThreadSyncTotal
    {
        static AutoResetEvent _workerEvent = new AutoResetEvent(false);
        static AutoResetEvent _mainEvent = new AutoResetEvent(false);
        public static void AutoResetEventTest(int second)
        {
            WriteLine("长时间任务");
            Sleep(TimeSpan.FromSeconds(second));
            WriteLine("完成");
            _workerEvent.Set();
            WriteLine("等待主线程完成工作");
            _mainEvent.WaitOne();
            WriteLine("开始另一个任务");
            Sleep(TimeSpan.FromSeconds(second));
            WriteLine("完成");
            _workerEvent.Set();
        }


        static ManualResetEventSlim _manualResetEvent = new ManualResetEventSlim();
        static void ManualResetEventSlimTest(string threadName, int second)
        {
            WriteLine($"{threadName} 休眠中");
            Sleep(TimeSpan.FromSeconds(second));
            WriteLine($"{threadName} 启动");
            _manualResetEvent.Wait();
            WriteLine($"{threadName} 进入工作");
        }

        public static void Main(string[] args)
        {
            // MutexTest.Test();


            // for(int i=0;i<6;i++){
            //     string threadName="Thread"+i;
            //     int second=2*i+2;
            //     Thread t=new Thread(()=>SemaphoreSlimTest.Test(threadName,second));
            //     t.Start();
            // }


            // var t=new Thread(()=>AutoResetEventTest(10));
            // t.Start();
            // WriteLine("等待来自工作线程的信号");
            // _workerEvent.WaitOne();
            // WriteLine("工作线程完成一次");
            // WriteLine("主线程开始工作");
            // Sleep(TimeSpan.FromSeconds(5));
            // _mainEvent.Set();
            // WriteLine("工作线程再次工作");
            // _workerEvent.WaitOne();
            // WriteLine("工作线程第二次完成");


            // var t1 = new Thread(() => ManualResetEventSlimTest("Thread 1", 4));
            // var t2 = new Thread(() => ManualResetEventSlimTest("Thread 2", 6));
            // var t3 = new Thread(() => ManualResetEventSlimTest("Thread 3", 8));
            // t1.Start();
            // t2.Start();
            // t3.Start();

            // Sleep(TimeSpan.FromSeconds(6));
            // WriteLine("它说，可以上了");
            // _manualResetEvent.Set();
            // Sleep(TimeSpan.FromSeconds(2));
            // _manualResetEvent.Reset();
            // WriteLine("天黑了");
            // Sleep(TimeSpan.FromSeconds(8));
            // WriteLine("它说，可以上了");
            // _manualResetEvent.Set();
            // Sleep(TimeSpan.FromSeconds(2));
            // WriteLine("天黑了");
            // _manualResetEvent.Reset();
            // _manualResetEvent.Dispose();

            // CountDownEventTest.Test();

            // Thread t1=new Thread(()=>BarrierTest.Test("a","b",5));
            // Thread t2=new Thread(()=>BarrierTest.Test("c","d",2));
            // t1.Start();
            // t2.Start();


            // new Thread(ReaderWriterLockSlimTest.Read){IsBackground=true}.Start();
            // new Thread(ReaderWriterLockSlimTest.Read){IsBackground=true}.Start();
            // new Thread(ReaderWriterLockSlimTest.Read){IsBackground=true}.Start();

            // new Thread(()=>ReaderWriterLockSlimTest.Write("Thread 1")){IsBackground=true}.Start();
            // new Thread(()=>ReaderWriterLockSlimTest.Write("Thread 2")){IsBackground=true}.Start();

            // Sleep(TimeSpan.FromSeconds(30));


            SpinWaitTest.Test();
        }
    }
}