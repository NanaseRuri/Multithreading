using System;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;
namespace Multithreading.ThreadSync
{
    public class BarrierTest
    {
        static Barrier _barrier = new Barrier(2, b => WriteLine($"第 {b.CurrentPhaseNumber+1}"));

        public static void Test(string name,string message,int second){
            for(int i=0;i<3;i++){
                WriteLine("-------------------------");
                Sleep(TimeSpan.FromSeconds(second));
                WriteLine($"{name}在{message}");
                Sleep(TimeSpan.FromSeconds(second));
                WriteLine($"{name}结束了{message}");
                _barrier.SignalAndWait();
            }
        }
    }
}