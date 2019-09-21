namespace Multithreading.ThreadBase
{
    public class LockTest : CounterBase
    {
        readonly object _syncRoot = new object();

        public int Count
        {
            get;
            private set;
        }

        public override void Increment()
        {
            lock (_syncRoot)
            {
                Count++;
            }
        }

        public override void Decrement()
        {
            lock (_syncRoot)
            {
                Count--;
            }
        }

        public void Run()
        {
            Increment();
            Decrement();
        }
    }

    public class NoLockTest : CounterBase
    {
        public int Count
        {
            get;
            private set;
        }

        public override void Increment()
        {
            Count++;
        }
        public override void Decrement()
        {
            Count--;
        }
        public void Run()
        {
            Increment();
            Decrement();
        }
    }

    public abstract class CounterBase
    {
        public abstract void Increment();
        public abstract void Decrement();
    }
}