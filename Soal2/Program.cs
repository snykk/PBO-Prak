using System;

namespace Soal2
{
    interface Module1
    {
        int Addition(int a, int b);
    }
    interface Module2
    {
        int Subtraction(int x, int y);
    }
    interface Module3
    {
        int Multiplication(int r, int s);
    }
    interface Module4
    {
        int Division(int c, int d);
    }
    public class Handle : Module1
    {
        public virtual int Addition(int a, int b)
        {
            throw new NotImplementedException();
        }
        public virtual int Subtraction(int x, int y)
        {
            throw new NotImplementedException();
        }
        public virtual int Multiplication(int r, int s)
        {
            throw new NotImplementedException();
        }
        public virtual int Division(int c, int d)
        {
            throw new NotImplementedException();
        }
    }
    public class Calculator : Handle
    {

        public override int Addition(int a, int b)
        {
            return a + b;
        }
        public override int Subtraction(int x, int y)
        {
            return x - y;
        }
        public override int Multiplication(int r, int s)
        {
            return r * s;
        }
        public override int Division(int c, int d)
        {
            return c / d;
        }

    }
    public class Progam
    {
        static void Main(string[] args)
        {
            Calculator kalkulator = new Calculator();
            Console.WriteLine(kalkulator.Addition(1, 2));
            Console.WriteLine(kalkulator.Subtraction(1, 2));
            Console.WriteLine(kalkulator.Multiplication(1, 2));
            Console.WriteLine(kalkulator.Division(4, 2));
        }
    }
}