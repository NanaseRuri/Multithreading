using System;
using System.Threading;
namespace Multithreading.ThreadBase
{
    public class BackgroundThreadTest
    {
        public static void Test(){
            Thread t1=new Thread(QuickStart.PrintNumber);
            Thread t2=new Thread(QuickStart.PrintNumber);
            Thread t3=new Thread(()=>{
                for(int i=0;i<10;i++)
                    {
                        Console.WriteLine(i);
                    }            
            });
            t2.IsBackground=true;
            t1.Start();
            t2.Start();            
            Console.WriteLine("后台线程测试");
        }
    }
}