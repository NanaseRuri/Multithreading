using System;
using System.Threading;
namespace Multithreading.ThreadBase
{
    public class ThreadPriorityTest
    {
        public static void Test(){
            ThreadSample sample=new ThreadSample();

            Thread t1=new Thread(sample.CountNumbers);
            t1.Name="Thread First";
            Thread t2=new Thread(sample.CountNumbers);
            t2.Name="Thread Second";

            t1.Priority=ThreadPriority.Highest;
            t2.Priority=ThreadPriority.Lowest;
            
            t1.Start();
            t2.Start();

            Thread.Sleep(TimeSpan.FromSeconds(2));
            sample.Stop();
        }

        class ThreadSample{
            bool _isStopped=false;

            public void Stop(){
                _isStopped=true;
            }

            public void CountNumbers(){
                long counter=0;
                while(!_isStopped){
                    counter++;
                }
                Console.WriteLine($"{Thread.CurrentThread.Name,13} 优先级： {Thread.CurrentThread.Priority,11} , 结果 {counter,13:N0}");
            }
        }
    }
}