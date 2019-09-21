// using System.Diagnostics;
// using System.Threading;
// using System;
// using Multithreading.ThreadBase;

// namespace Multithreading
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Thread t = new Thread(QuickStart.PrintNumber);
//             // t.Start();
//             // t.Join();
//             // Console.WriteLine("Completed");

//             // Console.WriteLine($"主线程优先级: {Thread.CurrentThread.Priority}");
//             // Console.WriteLine("全部核心跑结果");
//             // ThreadPriorityTest.Test();
//             // Thread.Sleep(TimeSpan.FromSeconds(2));
//             // Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(1);
//             // Console.WriteLine("单核");
//             // ThreadPriorityTest.Test();

//             // BackgroundThreadTest.Test();


//             // NoLockTest noLockTest = new NoLockTest();

//             // // Thread t1 = new Thread(() => TestCounter(noLockTest));
//             // // Thread t2 = new Thread(() => TestCounter(noLockTest));
//             // // Thread t3 = new Thread(() => TestCounter(noLockTest));
//             // Thread t1=new Thread(noLockTest.Run);
//             // Thread t2=new Thread(noLockTest.Run);
//             // Thread t3=new Thread(noLockTest.Run);
//             // t1.Start();
//             // t2.Start();
//             // t3.Start();
//             // t1.Join();
//             // t2.Join();
//             // t3.Join(); 
//             // Console.WriteLine(noLockTest.Count);

//             // LockTest lockTest = new LockTest();
//             // t1 = new Thread(() => TestCounter(lockTest));
//             // t2 = new Thread(() => TestCounter(lockTest));
//             // t3 = new Thread(() => TestCounter(lockTest));            
//             // t1.Start();
//             // t2.Start();
//             // t3.Start();
//             // t1.Join();
//             // t2.Join();
//             // t3.Join();
//             // Console.WriteLine(lockTest.Count);

//             Thread t1 = new Thread(ThreadExceptionTest.ThrowExceptionWithCatch);
//             t1.Start();
//             t1.Join();

//             try
//             {
//                 t1 = new Thread(ThreadExceptionTest.ThrowExceptionWithoutCatch);
//                 t1.Start();
//                 t1.Join();
//             }
//             catch (System.Exception e)
//             {
//                 Console.WriteLine(e.Message);
//             }
//         }



//         public static void TestCounter(CounterBase counter)
//         {
//             for (int i = 0; i < 100000; i++)
//             {
//                 counter.Increment();
//                 counter.Decrement();
//             }
//         }

//         public static void TestObjectPara(object obj)
//         {

//         }
//     }
// }
