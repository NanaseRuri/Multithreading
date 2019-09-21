using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace Multithreading.ThreadSync
{
    public class ReaderWriterLockSlimTest
    {
        static ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();
        static Dictionary<int, int> dic = new Dictionary<int, int>();

        public static void Read()
        {
            WriteLine("读取值");
            while (true)
            {
                try
                {
                    _lock.EnterReadLock();
                    foreach (var item in dic.Keys)
                    {
                        Sleep(TimeSpan.FromSeconds(0.1));
                        Console.WriteLine(dic[item]);
                    }
                }
                finally
                {
                    _lock.ExitReadLock();
                }
            }
        }

        public static void Write(string threadName)
        {
            while (true)
            {
                try
                {
                    int newKey = new Random().Next(225);
                    _lock.EnterUpgradeableReadLock();
                    if (!dic.ContainsKey(newKey))
                    {
                        try
                        {
                            _lock.EnterWriteLock();
                            dic[newKey] = newKey;
                            WriteLine($"{newKey} 添加到字典");
                        }
                        finally
                        {
                            WriteLine("写锁阻塞");
                            Sleep(TimeSpan.FromSeconds(1));
                            _lock.ExitWriteLock();
                            WriteLine("停止阻塞");
                        }
                    }
                    else
                    {
                        WriteLine("不使用写锁");
                    }
                }
                finally
                {
                    _lock.ExitUpgradeableReadLock();
                }
            }
        }
    }
}