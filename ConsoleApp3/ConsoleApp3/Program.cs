using System;

namespace ConsoleApp3
{
    abstract class sample
    {
        public abstract void print();
        public void show()
        {
            Console.WriteLine("hello world");
        }
    }
    class sample2 : sample 
    {
        public override void print()
        {
            Console.WriteLine("hello");
        }
    }
    class Program
    {
        static void Main5(string[] args)
        {
            sample2 s = new sample2();
            s.print();
            s.show();
        }
    }
}
