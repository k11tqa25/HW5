using System;

namespace Exercise8
{
    abstract class A
    {
        int X;
        public abstract void f(int n);
        public virtual void g(uint n)
        {
            X = (int)n;
        }
        public string ToString()
        {
            return X.ToString();
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
