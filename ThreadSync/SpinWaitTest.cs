using System;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;
namespace Multithreading.ThreadSync
{
    public class SpinWaitTest
    {
        static volatile bool _isCompleted = false;

        static void UserModeWait()
        {
            while (!_isCompleted)
            {
                Write('·');
            }
            WriteLine();
            WriteLine("用户模式完成");
        }

        static void HybridSpanWait()
        {
            var s = new SpinWait();
            while (!_isCompleted)
            {
                s.SpinOnce();
                WriteLine(s.NextSpinWillYield);
            }
            WriteLine("SpanWait 完成");
        }

        public static void Test()
        {
            var t1 = new Thread(UserModeWait);
            var t2 = new Thread(HybridSpanWait);

            WriteLine("用户模式");
            t1.Start();
            Sleep(TimeSpan.FromSeconds(1));
            _isCompleted = true;
            Sleep(TimeSpan.FromSeconds(1));
            _isCompleted = false;
            WriteLine("混合模式");
            t2.Start();
            Sleep(TimeSpan.FromSeconds(1));
            _isCompleted = true;        
        }
    }
}